using Acelera.OO.CarRental.AdditionalItems;
using Acelera.OO.CarRental.Pricing;
using Acelera.OO.CarRental.Vehicles;
using CarRental;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class RentalStoreTest
    {
        [TestMethod]
        public void WhenRequestedWithNoAdditionalsForOneDay_Rent_ShouldReturnARental() 
        {
            IVehicle carType = new PopularFamilyCar();
            var request = new RentalRequest
            {
                CarType = carType,
                Days = 1,
                Kilometers = 100
            };
            var factory = PricingFactory.Create();
            
            var rental = new RentalStore(factory).Rent(request);

            Assert.AreEqual(1, rental.Days);
            Assert.AreEqual(50M, rental.TotalDailyPrice);
            Assert.AreEqual(50M, rental.EstimatedTotalKmPrice);
            Assert.AreEqual(100M, rental.TotalPrice);
        }
        
        [TestMethod]
        public void WhenRequestedWithNoAdditionalsForMultipleDays_Rent_ShouldIncludePricesForTheDays() 
        {
            IVehicle carType = new PopularFamilyCar();
            var request = new RentalRequest
            {
                CarType = carType,
                Days = 4,
                Kilometers = 600
            };
            var factory = PricingFactory.Create();

            var rental = new RentalStore(factory).Rent(request);

            Assert.AreEqual(4, rental.Days);
            Assert.AreEqual(200M, rental.TotalDailyPrice);
            Assert.AreEqual(300M, rental.EstimatedTotalKmPrice);
            Assert.AreEqual(500M, rental.TotalPrice);
        }

        [TestMethod]
        public void WhenRequestedWithAdditionalsForMultipleDays_Rent_ShouldIncludeAdditionalsInThePrice() 
        {
            var carType = new PopularFamilyCar();

            var request = new RentalRequest
            {
                CarType = carType,
                Days = 4,
                Kilometers = 600
            };
            request.AddAccessory(new CarSeat());

            var pricingFactory = PricingFactory.Create();
            var rental = new RentalStore(pricingFactory).Rent(request);

            Assert.AreEqual(4, rental.Days);
            Assert.AreEqual(200M, rental.TotalDailyPrice);
            Assert.AreEqual(300M, rental.EstimatedTotalKmPrice);
            Assert.AreEqual(500M, rental.TotalPrice);
        }
    }
}
