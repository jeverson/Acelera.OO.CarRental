namespace Acelera.OO.CarRental.AdditionalItems
{
    public interface IAdditionalItem
    {
    }

    public interface ICarItem : IAdditionalItem
    {
    }
    
    public interface IMotorHomeItem : IAdditionalItem
    {
    }

    public interface IGeneralOptionalItem : ICarItem, IMotorHomeItem
    {
    }

}