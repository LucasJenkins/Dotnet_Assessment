using DotnetAssessmentSocialMedia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAssessmentSocialMedia.Services
{
    public class ValidationService:IValidationService
    {
        private readonly SocialMediaContext _context;

        IUserService UserService { get; set; }

        public ValidationService(UserService userService, SocialMediaContext context)
        {
            UserService = userService;
            _context = context;
        }
        public bool UserNameExists(string username)
        {
            var users = UserService.GetAll();
            var user = users.SingleOrDefault(u1 => u1.Credentials.Username == username);
            return user != null ? true : false;
        }

        public bool UserNameAvailable(string username)
        {
            return !UserNameExists(username);
        }

        public bool HashtagExists(string label)
        {
            var hashtag = _context.Hashtags.FirstOrDefault(h1 => h1.Label == label);
            return hashtag != null ? true : false;
        }
    }
}
