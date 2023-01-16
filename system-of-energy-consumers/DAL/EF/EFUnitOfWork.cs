using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.UnitOfWork;
using DAL.Repositories.Impl;
using DAL.Entities;

namespace DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private UserContext db;
        private UserRepository userRepository;
        private HouseRepository houseRepository;
        private EnergyIndicatorRepository energyIndicatorRepository;
        private OperationalIndicatorRepository operationalIndicatorRepository;
        
        public EFUnitOfWork(DbContextOptions options)
        {
            db = new UserContext(options);
        }
        public IRepository<User> users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }
        public IRepository<House> houses
        {
            get
            {
                if (houseRepository == null)
                    houseRepository = new HouseRepository(db);
                return houseRepository;
            }
        }

        public IRepository<EnergyIndicator> energyIndicators
        {
            get
            {
                if (energyIndicatorRepository == null)
                    energyIndicatorRepository = new EnergyIndicatorRepository(db);
                return energyIndicatorRepository;
            }
        }

        public IRepository<OperationalIndicator> operationalIndicators
        {
            get
            {
                if (operationalIndicatorRepository == null)
                    operationalIndicatorRepository = new OperationalIndicatorRepository(db);
                return operationalIndicatorRepository;
            }
        }

        IUserRepository IUnitOfWork.users => throw new NotImplementedException();

        IHouseRepository IUnitOfWork.houses => throw new NotImplementedException();

        IOperationalIndicatorRepository IUnitOfWork.operationalIndicators => throw new NotImplementedException();

        IEnergyIndicatorRepository IUnitOfWork.energyIndicators => throw new NotImplementedException();

        public void Save()
        {
            db.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
