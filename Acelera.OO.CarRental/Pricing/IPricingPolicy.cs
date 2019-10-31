using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental
{
    public interface IPricingPolicy
    {
        decimal GetKmPrice();
        decimal GetDailyRentPrice();
        decimal GetAdditionalItemPrice();
        bool AppliesTo(IVehicle vehicle);
    }
}
