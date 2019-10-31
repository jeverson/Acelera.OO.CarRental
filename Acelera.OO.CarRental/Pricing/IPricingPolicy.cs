namespace Acelera.OO.CarRental
{
    public interface IPricingPolicy
    {
        decimal GetKmPrice();
        decimal GetDailyRentPrice();
        decimal GetAdditionalItemPrice();
    }
}
