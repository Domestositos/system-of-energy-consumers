using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public class AdminHouse : CurrentUser
    {
        public AdminHouse(int userId, string log) : base(userId, log, nameof(AdminHouse))
        {

        }
    }
}
