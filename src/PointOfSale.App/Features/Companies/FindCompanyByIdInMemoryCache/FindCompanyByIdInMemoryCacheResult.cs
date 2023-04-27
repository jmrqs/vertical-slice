namespace PointOfSale.App.Features.Companies.FindCompanyByIdInMemoryCache;

public class FindCompanyByIdInMemoryCacheResult
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? LogoPath { get; init; }
}
