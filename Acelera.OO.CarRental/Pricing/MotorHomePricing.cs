using Acelera.OO.CarRental.AdditionalItems;
using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental.Pricing
{
    public class MotorHomePricing : PricingPolicyBase<IMotorHomeItem>
    {
        protected override PriceTable<IMotorHomeItem> GetPriceTable()
        {
            var priceTable = new PriceTable<IMotorHomeItem>();
            priceTable.AddItem(typeof(CarSeat), 75);
            priceTable.AddItem(typeof(Gps), 35);
            priceTable.AddItem(typeof(Refrigerator), 250);
            return priceTable;
        }

        public override bool AppliesTo(IVehicle vehicle) 
            => vehicle is MotorHome;
        public override decimal GetDailyRentPrice() => 0;
        
        public override decimal GetKmPrice() => 0;

    }
}
