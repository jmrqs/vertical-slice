namespace PointOfSale.BuildingBlocks.Exception;

public class ValidationException : System.Exception
{
    public ValidationException(string message) : base(message)
    {
    }
}