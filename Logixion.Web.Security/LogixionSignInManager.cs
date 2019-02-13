using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Logixion.Web.Security
{
    // Configure the application sign-in manager which is used in this application.
    public class LogixionSignInManager : SignInManager<ApplicationUser, string>
    {
        public LogixionSignInManager( LogixionUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
        {
            return user.GenerateUserIdentityAsync(( LogixionUserManager)UserManager);
        }

        public static LogixionSignInManager Create(IdentityFactoryOptions<LogixionSignInManager> options, IOwinContext context)
        {
            return new LogixionSignInManager(context.GetUserManager< LogixionUserManager>(), context.Authentication);
        }
    }
} 