using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webportfolio.Data;


namespace Webportfolio.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<IdentityUser> userManager;
        public UsersController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }
        [HttpGet]
        public string LoginFunction(string userName, string password)
        {
            IdentityUser identityUser = dbContext.Users.FirstOrDefault(e => e.UserName == userName);
            if (identityUser != null)
            {
                var verificationResult = userManager.PasswordHasher.VerifyHashedPassword(identityUser, identityUser.PasswordHash, password);
                if (verificationResult == PasswordVerificationResult.Success)
                {
                    return identityUser.Id;
                }
            }
            return null;
        }
    }
}
