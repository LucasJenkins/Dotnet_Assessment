using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAssessmentSocialMedia.Data.Entities
{
    public class Context
    {
        public Tweet Target { get; set; }
        public Tweet Before { get; set; }
        public Tweet After { get; set; }
    }
}
