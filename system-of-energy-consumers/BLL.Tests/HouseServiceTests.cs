using BLL.Services.Impl;
using BLL.Services.Interfaces;
using CCL.Security;
using CCL.Security.Identity;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    public class HouseServiceTests
    {
        [Fact]
        public void Ctor_InputNull_ThrowArgumentNullException()
        {
            // Arrange
            IUnitOfWork nullUnitOfWork = null;
            Assert.Throws<ArgumentNullException>(() => new HouseService(nullUnitOfWork));
        }

        [Fact]
        public void GetHouses_UserIsAdmin_ThrowMethodAccessException()
        {
            // Arrange
            CurrentUser user = new OrdinaryUser(1, "test");
            SecurityContext.SetUser(user);
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            IHouseService houseService = new HouseService(mockUnitOfWork.Object);
            Assert.Throws<MethodAccessException>(() => houseService.GetHouses(0));
        }

        [Fact]
        public void GetHouses_HousesFromDAL_CorrectMappingToHousesDTO()
        {
            // Arrange
            CurrentUser user = new AdminSystem(1, "test");
            SecurityContext.SetUser(user);
            var houseService = GetHouseService();
            var actualHouseDto = houseService.GetHouses(0).First();
            Assert.True(actualHouseDto.Id == 1 && actualHouseDto.Address.Equals("Chernigiv") && actualHouseDto.Email.Equals("test@gmail.com")
                && actualHouseDto.PhoneNumber.Equals("+380968564786") && actualHouseDto.UserId == 1);
        }
        IHouseService GetHouseService()
        { 
            var mockContext = new Mock<IUnitOfWork>();
            var expectedHouse = new House()
            {
                id = 1,
                address = "Chernigiv",
                email = "test@gmail.com",
                phoneNumber = "+380968564786",
                userId = 1
            };
            var mockDbSet = new Mock<IHouseRepository>();
            mockDbSet.Setup(z => z.Find(It.IsAny<Func<House, bool>>(), It.IsAny<int>(), It.IsAny<int>())).Returns(new List<House>() { expectedHouse });
            mockContext.Setup(context => context.houses).Returns(mockDbSet.Object);
            IHouseService houseService = new HouseService(mockContext.Object);
            return houseService;
        }
    }
}
