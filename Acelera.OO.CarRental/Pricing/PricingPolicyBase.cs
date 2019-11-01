using Acelera.OO.CarRental.AdditionalItems;
using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental.Pricing
{
    public abstract class PricingPolicyBase<T> : IPricingPolicy
        where T : IAdditionalItem 
    {
        protected abstract PriceTable<T> GetPriceTable();

        public abstract decimal GetKmPrice();
        public abstract decimal GetDailyRentPrice();
        public abstract bool AppliesTo(IVehicle vehicle);


        private readonly PriceTable<T> _priceTable;
        public PricingPolicyBase()
        {
            _priceTable = GetPriceTable();
        }

        public virtual decimal GetItemPrice(IAdditionalItem item) 
            => _priceTable.GetPrice(item.GetType());
    }
}
