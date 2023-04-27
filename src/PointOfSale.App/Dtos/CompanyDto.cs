using PointOfSale.Core.Companies;

namespace PointOfSale.App.Dtos;

public class CompanyDto
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? LogoPath { get; init; }
}
