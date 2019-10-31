using Acelera.OO.CarRental.AdditionalItems;
using Acelera.OO.CarRental.Vehicles;
using System;
using System.Collections.Generic;

namespace Acelera.OO.CarRental
{
    public class RentalRequest
    {
        private readonly List<IAdditionalItem> _optionalItems;
        public RentalRequest()
        {
            _optionalItems = new List<IAdditionalItem>();
        }

        public IVehicle CarType { get; set; }
        public int Days { get; set; }
        public int Kilometers { get; set; }

        public void AddAccessory(IAdditionalItem item)
        {
            _optionalItems.Add(item);
        }

        public IReadOnlyList<IAdditionalItem> OptionalItems => _optionalItems.AsReadOnly();
    }
}
