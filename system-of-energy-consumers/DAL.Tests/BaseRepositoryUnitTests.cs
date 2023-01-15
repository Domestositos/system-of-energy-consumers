using DAL.EF;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tests
{
    public class BaseRepositoryUnitTests
    {
        [Fact]
        public void Create_InputHouseInstance_CalledAddMethodOfDBSetWithHouseInstance()
        {
            DbContextOptions opt = new DbContextOptionsBuilder<UserContext>().Options;
            var mockContext = new Mock<UserContext>(opt);
            var mockDbSet = new Mock<DbSet<House>>();
            mockContext.Setup(context => context.Set<House>()).Returns(mockDbSet.Object);
            var repository = new TestHouseRepository(mockContext.Object);
            House expectedStreet = new Mock<House>().Object;
            repository.Create(expectedStreet);
            mockDbSet.Verify(dbSet => dbSet.Add(expectedStreet), Times.Once());
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            DbContextOptions opt = new DbContextOptionsBuilder<UserContext>().Options;
            var mockContext = new Mock<UserContext>(opt);
            var mockDbSet = new Mock<DbSet<House>>();
            mockContext.Setup(context => context.Set<House>()).Returns(mockDbSet.Object);
            var repository = new TestHouseRepository(mockContext.Object);
            House expectedStreet = new House() { id = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedStreet.id)).Returns(expectedStreet);
            repository.Delete(expectedStreet.id);
            mockDbSet.Verify(dbSet => dbSet.Find(expectedStreet.id), Times.Once());
            mockDbSet.Verify(dbSet => dbSet.Remove(expectedStreet), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            DbContextOptions opt = new DbContextOptionsBuilder<UserContext>().Options;
            var mockContext = new Mock<UserContext>(opt);
            var mockDbSet = new Mock<DbSet<House>>();
            mockContext.Setup(context =>context.Set<House>()).Returns(mockDbSet.Object);
            House expectedStreet = new House() { id = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedStreet.id)).Returns(expectedStreet);
            var repository = new TestHouseRepository(mockContext.Object);
            var actualStreet = repository.Get(expectedStreet.id);
            mockDbSet.Verify(dbSet => dbSet.Find(expectedStreet.id), Times.Once());
            Assert.Equal(expectedStreet, actualStreet);
        }
    }
}
