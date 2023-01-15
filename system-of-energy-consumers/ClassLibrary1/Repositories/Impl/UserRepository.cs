using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using DAL.EF;


namespace DAL.Repositories.Impl
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        internal UserRepository(UserContext context) : base(context)
        {
        }
    }
}
