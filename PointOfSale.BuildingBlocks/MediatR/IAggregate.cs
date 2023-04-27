namespace PointOfSale.BuildingBlocks.MediatR;

public interface IAggregate : IAggregate<int>
{
}

public interface IAggregate<T>
{
    public T Id { get; }
}