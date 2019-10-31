using Acelera.OO.CarRental.Pricing;
using Acelera.OO.CarRental.Vehicles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class PricingFactoryTest
    {
        [TestMethod]
        public void Basic_list_should_be_created_for_basic_cars() 
        {
            var car = new PopularFamilyCar();
            var factory = PricingFactory.Create();

            var policy = factory.GetPolicyFor(car);

            Assert.IsInstanceOfType(policy, typeof(PopularFamilyCarPricing));
        }

        [TestMethod]
        public void MotorHome_list_should_be_created_for_motorhomes()
        {
            var car = new MotorHome();
            var factory = PricingFactory.Create();

            var policy = factory.GetPolicyFor(car);

            Assert.IsInstanceOfType(policy, typeof(MotorHomePricing));
        }
    }
}
