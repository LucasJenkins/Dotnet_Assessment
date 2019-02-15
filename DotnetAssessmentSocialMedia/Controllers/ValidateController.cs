using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DotnetAssessmentSocialMedia.Data.Entities;
using DotnetAssessmentSocialMedia.Dtos;
using DotnetAssessmentSocialMedia.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotnetAssessmentSocialMedia.Controllers
{
    [Route("api/validate")]
    [ApiController]
    public class ValidateController : ControllerBase
    {
        private IValidationService _validationService;
        
        public ValidateController(IValidationService validationService)
        {
            _validationService = validationService;
        }
        
        // GET validate/tag/exist/
        [HttpGet("/tag/exist/{label}")]
        public ActionResult<bool> HashtagExists(string label)
        {
            var hashtag = _validationService.HashtagExists(label);
            return Ok(hashtag);
        }

        // GET validate/username/available/@{username}
        [HttpGet("/username/available/@{username}")]
        [ProducesResponseType(404)]
        public ActionResult<bool> UsernameAvailable(string username)
        {
            var user = _validationService.UserNameAvailable(username);
            return Ok(user);
        }

        // POST validate/username/exists/@{username}
        [HttpGet("/username/exists/@{username}")]
        [ProducesResponseType(400)]
        public ActionResult<bool> UserExists(string username)
        {
            var user = _validationService.UserNameExists(username);
            return Ok(user);
        }
    }
}