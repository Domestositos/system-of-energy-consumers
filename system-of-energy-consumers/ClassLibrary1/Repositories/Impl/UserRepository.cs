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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(UserContext context) : base(context)
        {
        }
    }
}
