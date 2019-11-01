using Acelera.OO.CarRental.AdditionalItems;
using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental
{
    public interface IPricingPolicy
    {
        decimal GetKmPrice();
        decimal GetDailyRentPrice();
        decimal GetItemPrice(IAdditionalItem item);
        bool AppliesTo(IVehicle vehicle);
    }
}
