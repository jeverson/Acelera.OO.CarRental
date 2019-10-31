﻿using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental.Pricing
{
    public class PopularFamilyCarPricing : IPricingPolicy
    {
        public bool AppliesTo(IVehicle vehicle) 
            => vehicle is PopularFamilyCar;

        public decimal GetAdditionalItemPrice()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetDailyRentPrice() => 50M;

        public decimal GetKmPrice() => 0.5M;
    }
}
