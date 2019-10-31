using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental.Pricing
{
    public interface IPricingFactory
    {
        IPricingPolicy GetPolicyFor(IVehicle vehicle);
    }
}
