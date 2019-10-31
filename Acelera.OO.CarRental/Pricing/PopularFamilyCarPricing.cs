namespace Acelera.OO.CarRental.Pricing
{
    public class PopularFamilyCarPricing : IPricingPolicy
    {
        public decimal GetAdditionalItemPrice()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetDailyRentPrice() => 50M;

        public decimal GetKmPrice() => 0.5M;
    }
}
