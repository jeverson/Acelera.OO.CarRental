using Acelera.OO.CarRental.AdditionalItems;
using Acelera.OO.CarRental.Pricing;
using Acelera.OO.CarRental.Vehicles;
using CarRental;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class RentalStoreTest
    {

        [TestMethod]
        public void Rental_prices_should_account_for_days_and_kilometers() 
        {
            IVehicle carType = new PopularFamilyCar();
            var request = BuildRentalRequest(new PopularFamilyCar(), 4, 600);
            var factory = PricingFactory.Create();

            var rental = new RentalStore(factory).Rent(request);

            Assert.AreEqual(4, rental.Days);
            Assert.AreEqual(200M, rental.TotalDailyPrice);
            Assert.AreEqual(300M, rental.EstimatedTotalKmPrice);
            Assert.AreEqual(500M, rental.TotalPrice);
        }

        [TestMethod]
        public void Rental_prices_should_account_for_valid_additional_items() 
        {
            var request = BuildRentalRequest(new PopularFamilyCar(), 4, 600);
            request.AddAccessory(new CarSeat());

            var pricingFactory = PricingFactory.Create();
            var rental = new RentalStore(pricingFactory).Rent(request);

            Assert.AreEqual(4, rental.Days);
            Assert.AreEqual(200M, rental.TotalDailyPrice);
            Assert.AreEqual(300M, rental.EstimatedTotalKmPrice);
            Assert.AreEqual(65M, rental.AdditionalItemsPrice);
            Assert.AreEqual(565M, rental.TotalPrice);
        }

        [TestMethod]
        public void Invalid_items_should_not_be_included_in_total_price()
        {
            var request = BuildRentalRequest(new PopularFamilyCar(), 4, 600);
            request.AddAccessory(new Refrigerator());

            var pricingFactory = PricingFactory.Create();
            var rental = new RentalStore(pricingFactory).Rent(request);

            Assert.AreEqual(500M, rental.TotalPrice);
        }

        private static RentalRequest BuildRentalRequest(IVehicle vehicle, int days, int kms)
        {
            return new RentalRequest
            {
                CarType = vehicle,
                Days = days,
                Kilometers = kms
            };
        }
    }
}
