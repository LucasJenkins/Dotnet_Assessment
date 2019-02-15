using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAssessmentSocialMedia.Data.Entities
{
    public class Hashtag
    {
        public string Label { get; set; }
        DateTime FirstUsed { get; set; }
        public DateTime LastUsed { get; set; }
    }
}
