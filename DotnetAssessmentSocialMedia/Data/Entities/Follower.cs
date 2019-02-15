using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAssessmentSocialMedia.Data.Entities
{
    public class Follower
    {
        public int id { get; set; }
        public Profile profile { get; set; }
        public List<Tweet> Tweets { get; set; }
    }
}
