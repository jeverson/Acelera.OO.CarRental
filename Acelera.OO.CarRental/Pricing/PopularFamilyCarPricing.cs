using Acelera.OO.CarRental.AdditionalItems;
using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental.Pricing
{
    public class PopularFamilyCarPricing : PricingPolicyBase<IGeneralOptionalItem>
    {
        protected override PriceTable<IGeneralOptionalItem> GetPriceTable()
        {
            var _priceTable = new PriceTable<IGeneralOptionalItem>();
            _priceTable.AddItem(typeof(CarSeat), 65);
            _priceTable.AddItem(typeof(Gps), 25);
            return _priceTable;
        }

        public override bool AppliesTo(IVehicle vehicle) 
            => vehicle is PopularFamilyCar;

        public override decimal GetDailyRentPrice() => 50M;

        public override decimal GetKmPrice() => 0.5M;

    }
}
