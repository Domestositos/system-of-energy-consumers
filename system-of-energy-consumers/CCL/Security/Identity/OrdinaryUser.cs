using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public class OrdinaryUser : CurrentUser
    {
        public OrdinaryUser(int userId, string log) : base(userId, log, nameof(AdminSystem))
        {

        }
    }
}
