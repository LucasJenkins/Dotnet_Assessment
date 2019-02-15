using DotnetAssessmentSocialMedia.Data.Entities;
using DotnetAssessmentSocialMedia.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAssessmentSocialMedia.Services
{
    interface ITweetService
    {
        bool TweetExisits(int id);
        List<Tweet> GetUserFeed(string username);
        List<Tweet> GetUserTweets(string username);
        List<Tweet> UserMentionedIn(string username);
        HashSet<string> GetAllHashtags();
        List<Tweet> HashTaggedTweets(string label);
        List<Tweet> GetAllTweets();
        Tweet CreateTweet(string content, CredentialsDto credentials);

    }
}
