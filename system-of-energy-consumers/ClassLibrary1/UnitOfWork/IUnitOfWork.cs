using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Interfaces;

namespace DAL.UnitOfWork
{
    internal interface IUnitOfWork
    {
        public interface IUnitOfWork : IDisposable
        {
            IUserRepository users { get; }
            IHouseRepository houses { get; }
            IOperationalIndicatorRepository operationalIndicators { get; }
            IEnergyIndicatorRepository energyIndicators { get; }
            void Save();
        }
    }
}
