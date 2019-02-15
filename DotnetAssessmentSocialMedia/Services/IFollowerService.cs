using DotnetAssessmentSocialMedia.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAssessmentSocialMedia.Services
{
    interface IFollowerService
    {
        bool Follow(Credentials credentials, string username);
        bool Unfollow(Credentials credentials, string username);
        List<User> GetFollowers(string username);
        List<User> GetFollowingList(string username);
    }
}
