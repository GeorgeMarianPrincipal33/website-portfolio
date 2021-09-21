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
        public IEnumerable<CV> GetCVs()
        {
            return dbContext.CVs.ToArray();
        }
    }
}