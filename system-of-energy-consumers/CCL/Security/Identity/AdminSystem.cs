using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public class AdminSystem : CurrentUser
    {
        public AdminSystem(int userId, string log ) : base (userId,log,nameof(AdminSystem))
        { 
            
        }
    }
}
