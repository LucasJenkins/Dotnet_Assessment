using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetAssessmentSocialMedia.Data.Entities;

namespace DotnetAssessmentSocialMedia.Services
{
    public class FollowerService : IFollowerService
    {
        public bool Follow(Credentials credentials, string username)
        {
            throw new NotImplementedException();
        }

        public List<User> GetFollowers(string username)
        {
            throw new NotImplementedException();
        }

        public List<User> GetFollowingList(string username)
        {
            throw new NotImplementedException();
        }

        public bool Unfollow(Credentials credentials, string username)
        {
            throw new NotImplementedException();
        }
    }
}
