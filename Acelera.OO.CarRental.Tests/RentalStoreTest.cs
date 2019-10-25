using CarRental;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class RentalStoreTest
    {
        [TestMethod]
        public void WhenRequestedToRentWithNoAdditionalsForOneDay_Rent_ShouldReturnARentalOperation() 
        {
            ICarType carType = new BasicTestCarType { DailyPrice = 50M, KmPrice = 0.5M };

            var request = new RentalRequest
            {
                CarType = carType,
                Days = 1,
                Kilometers = 100
            };

            var rental = new RentalStore().Rent(request);

            Assert.AreEqual(1, rental.Days);
            Assert.AreEqual(50M, rental.TotalDailyPrice);
            Assert.AreEqual(50M, rental.EstimatedTotalKmPrice);
            Assert.AreEqual(100M, rental.TotalPrice);
        }
        
        [TestMethod]
        public void WhenRequestedToRentWithNoAdditionalsForMultipleDays_Rent_ShouldReturnARentalOperation() 
        {
            ICarType carType = new BasicTestCarType { DailyPrice = 50M, KmPrice = 0.5M };

            var request = new RentalRequest
            {
                CarType = carType,
                Days = 4,
                Kilometers = 600
            };

            var rental = new RentalStore().Rent(request);

            Assert.AreEqual(4, rental.Days);
            Assert.AreEqual(200M, rental.TotalDailyPrice);
            Assert.AreEqual(300M, rental.EstimatedTotalKmPrice);
            Assert.AreEqual(500M, rental.TotalPrice);
        }
    }
}
