using Acelera.OO.CarRental.AdditionalItems;
using Acelera.OO.CarRental.Pricing;
using Acelera.OO.CarRental.Vehicles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class PriceTableTest
    {
        [TestMethod]
        public void Invalid_items_should_throw()
        {
            var item = new Refrigerator();
            var priceTable = new PriceTable<ICarItem>();

            Assert.ThrowsException<InvalidOperationException>(() => priceTable.AddItem(item.GetType(), 10));
        }
    }
}
