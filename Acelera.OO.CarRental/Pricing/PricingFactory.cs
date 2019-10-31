using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental.Pricing
{
    public class PricingFactory : IPricingFactory
    {
        private static PricingFactory _instance;

        private PricingFactory() { }

        public static IPricingFactory Create()
        {
            if (_instance == null)
                _instance = new PricingFactory();

            return _instance;
        }

        public IPricingPolicy GetPolicyFor(IVehicle vehicle)
        {
            return new PopularFamilyCarPricing();
        }
    }
}
