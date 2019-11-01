using System;
using System.Collections.Generic;
using System.Linq;
using Acelera.OO.CarRental;
using Acelera.OO.CarRental.AdditionalItems;
using Acelera.OO.CarRental.Pricing;

namespace CarRental
{
    public class RentalStore
    {
        private IPricingFactory pricingFactory;

        public RentalStore(IPricingFactory pricingFactory)
        {
            this.pricingFactory = pricingFactory;
        }

        public RentalResponse Rent(RentalRequest request)
        {
            var pricing = pricingFactory.GetPolicyFor(request.CarType);

            return new RentalResponse {
                Days = request.Days,
                EstimatedTotalKmPrice = request.Kilometers * pricing.GetKmPrice(),
                TotalDailyPrice = request.Days * pricing.GetDailyRentPrice(),
                AdditionalItemsPrice = GetAdditionalItemsPrice(request.OptionalItems, pricing)
            };
        }

        private decimal GetAdditionalItemsPrice(IReadOnlyList<IAdditionalItem> optionalItems, IPricingPolicy pricing)
        {
            var prices = optionalItems.Select(i => pricing.GetItemPrice(i));
            return prices.Sum();
        }
    }
}
