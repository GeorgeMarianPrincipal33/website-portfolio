using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webportfolio.Models;

namespace Webportfolio.Services
{
    public interface ICVService
    {
        IEnumerable<CV> GetCVs();

        CV GetCv(int id);

    }
}