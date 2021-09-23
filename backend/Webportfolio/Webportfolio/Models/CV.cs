using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webportfolio.Models
{
    public class CV
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string ContactDetails { get; set; }

        public string Certifications { get; set; }

        public string PlacesOfWork { get; set; }

        public string Skills { get; set; }

        public string ProfilePicture { get; set; }
    }
}
