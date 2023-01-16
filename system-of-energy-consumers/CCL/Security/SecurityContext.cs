using CCL.Security.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security
{
    public static class SecurityContext
    {
        static CurrentUser _user = null;
        public static CurrentUser GetUser() {
            return _user;
        }
        public static void SetUser(CurrentUser user)
        {
            _user = user;
        }
    }
}
