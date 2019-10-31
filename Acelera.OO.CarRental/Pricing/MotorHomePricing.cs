using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental.Pricing
{
    public class MotorHomePricing : IPricingPolicy
    {
        public bool AppliesTo(IVehicle vehicle) 
            => vehicle is MotorHome;

        public decimal GetAdditionalItemPrice()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetDailyRentPrice() => 0;

        public decimal GetKmPrice() => 0;
    }
}
