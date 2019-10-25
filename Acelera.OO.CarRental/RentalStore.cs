using System;
using Acelera.OO.CarRental;

namespace CarRental
{
    public class RentalStore
    {
        public RentalResponse Rent(RentalRequest request)
        {
            return new RentalResponse { 
                Days = request.Days, 
                EstimatedTotalKmPrice = request.Kilometers * request.CarType.KmPrice, 
                TotalDailyPrice = request.Days * request.CarType.DailyPrice
            };
        }
    }
}
