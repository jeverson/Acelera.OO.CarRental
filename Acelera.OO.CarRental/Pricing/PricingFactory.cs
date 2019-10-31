using Acelera.OO.CarRental.Vehicles;
using System.Linq;

namespace Acelera.OO.CarRental.Pricing
{
    public class PricingFactory : IPricingFactory
    {
        private static PricingFactory _instance;
        private IPricingPolicy[] _pricingPolicies;

        private PricingFactory()
        {
            InitPricingPolicies();
        }

        private void InitPricingPolicies()
        {
            _pricingPolicies = new IPricingPolicy[]
            {
                new MotorHomePricing(),
                new PopularFamilyCarPricing()
            };
        }

        public static IPricingFactory Create()
        {
            if (_instance == null)
                _instance = new PricingFactory();

            return _instance;
        }

        public IPricingPolicy GetPolicyFor(IVehicle vehicle) 
            => _pricingPolicies.First(p => p.AppliesTo(vehicle));
    }
}
