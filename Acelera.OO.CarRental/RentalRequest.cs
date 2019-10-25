namespace Acelera.OO.CarRental
{
    public class RentalRequest
    {
        public ICarType CarType { get; set; }
        public int Days { get; set; }
        public int Kilometers { get; set; }
    }
}
