using Microsoft.AspNet.Identity.EntityFramework;

namespace Logixion.Web.Security
{
    public class UserDbContext:IdentityDbContext<ApplicationUser>
    {
        private static UserDbContext _userDbContext=null;
        public UserDbContext():base("DefaultConnection")
        {

        }
        public static UserDbContext Create()
        {

            if (_userDbContext == null)
                _userDbContext = new UserDbContext();
            return _userDbContext;
        }
    }
}
