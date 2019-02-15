using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAssessmentSocialMedia.Data.Entities
{
    [Owned]
    public class Tweet
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public DateTime Posted { get; set; }
        public string Content { get; set; }
        public Tweet InReplyTo { get; set; }
        public Tweet RepostOf { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
