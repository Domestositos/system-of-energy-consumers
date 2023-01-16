using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public abstract class CurrentUser
    {
        public CurrentUser(int userId, string log, string userType)
        {
            UserId = userId;
            Log = log;
            UserType = userType;
        }
        public int UserId { get; }
        public string Log { get; }
        protected string UserType { get; }
    }
}
