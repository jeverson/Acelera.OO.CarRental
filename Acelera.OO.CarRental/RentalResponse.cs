namespace CarRental
{
    public class RentalResponse
    {
        public int Days { get; set; }
        public decimal TotalDailyPrice { get; set; }
        public decimal EstimatedTotalKmPrice { get; set; }
        public decimal AdditionalItemsPrice { get; set; }
        public decimal TotalPrice => TotalDailyPrice + EstimatedTotalKmPrice + AdditionalItemsPrice;

    }
}