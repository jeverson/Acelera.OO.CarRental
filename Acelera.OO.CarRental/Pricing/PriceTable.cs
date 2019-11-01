using System;
using System.Collections.Generic;
using System.Linq;

namespace Acelera.OO.CarRental.Pricing
{
    public class PriceTable<T>
    {
        private Dictionary<Type, decimal> _priceList;

        public PriceTable()
        {
            _priceList = new Dictionary<Type, decimal>();
        }

        public void AddItem(Type type, decimal price)
        {
            GuardIsValidItem(type);

            if (!_priceList.ContainsKey(type))
                _priceList.Add(type, price);
        }

        private static void GuardIsValidItem(Type type)
        {
            if (!type.GetInterfaces().Contains(typeof(T)))
                throw new InvalidOperationException("Invalid type of item added to price table.");
        }

        public decimal GetPrice(Type type) 
            => _priceList.ContainsKey(type) ? _priceList[type] : 0;
    }
}
