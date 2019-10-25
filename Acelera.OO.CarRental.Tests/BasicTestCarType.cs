using System;

namespace Acelera.OO.CarRental.Tests
{
    class BasicTestCarType : ICarType
    {
        public decimal DailyPrice { get; set; }
        public decimal KmPrice { get; set; }
    }
}
