using DAL.Entities;
using DAL.Repositories.Impl;
using Microsoft.EntityFrameworkCore;

namespace DAL.Tests
{
    public class TestHouseRepository:BaseRepository<House>
    {
        public TestHouseRepository(DbContext context)
        : base(context)
        {
        }
    }
}