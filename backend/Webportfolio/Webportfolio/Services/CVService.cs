using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webportfolio.Data;
using Webportfolio.Models;

namespace Webportfolio.Services
{
    public class CVService : ICVService
    {

        private readonly ApplicationDbContext dbContext;

        public CVService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public CV GetCv(int id)
        {

             return dbContext.CVs.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<CV> GetCVs()
        {
            return dbContext.CVs.ToArray();
        }

        public void UpdateCv(CV cv)
        {
            var entity = dbContext.CVs.FirstOrDefault(e => e.Id == cv.Id);
            if(entity!=null)
            {
                entity.Certifications = cv.Certifications;
                entity.ContactDetails = cv.ContactDetails;
                entity.Description = cv.Description;
                entity.PlacesOfWork = cv.PlacesOfWork;
                entity.Skills = cv.Skills;
            }
        }
    }
}