using System.Collections.Generic;
using DotnetAssessmentSocialMedia.Data.Entities;
using DotnetAssessmentSocialMedia.Dtos;

namespace DotnetAssessmentSocialMedia.Services
{
    public interface IUserService
    {
        User GetByUsername(string username);
        IEnumerable<User> GetAll();
        User CreateUser(User user);
        User DeleteUser(string username, CredentialsDto credentials);
        User UpdateProfile(CredentialsDto credentials, ProfileDto profile);
        
    }
}