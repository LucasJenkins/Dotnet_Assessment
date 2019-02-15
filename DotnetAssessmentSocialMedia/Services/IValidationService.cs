using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAssessmentSocialMedia.Services
{
    public interface IValidationService
    {
        bool UserNameExists(string username);
        bool UserNameAvailable(string username);
        bool HashtagExists(string label);
    }
}
