using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Webportfolio.Models
{
    public class CV
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public string Description { get; set; }

        public string ContactDetails { get; set; }

        public string Certifications { get; set; }

        public string PlacesOfWork { get; set; }

        public string Skills { get; set; }

        public string ProfilePicture { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
