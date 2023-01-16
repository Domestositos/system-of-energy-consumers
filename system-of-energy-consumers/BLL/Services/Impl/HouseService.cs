using AutoMapper;
using BLL.DTO;
using BLL.Services.Interfaces;
using CCL.Security;
using CCL.Security.Identity;
using DAL.EF;
using DAL.Entities;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Impl
{
    public class HouseService : IHouseService
    { 
        private readonly IUnitOfWork _database;
        private int pageSize = 10;
        public HouseService(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            _database = unitOfWork;
        }
        public IEnumerable<HouseDTO> GetHouses(int pageNumber)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(AdminSystem)
                && userType != typeof(AdminHouse))
            {
                throw new MethodAccessException();
            }
            var housesEntities =_database.houses.Find(z => z.userId == user.UserId, pageNumber, pageSize);
            var mapper =new MapperConfiguration(cfg => cfg.CreateMap<House, HouseDTO>()).CreateMapper();
            var streetsDto =mapper.Map<IEnumerable<House>, List<HouseDTO>>(housesEntities);
            return streetsDto;
        }
    }
}
