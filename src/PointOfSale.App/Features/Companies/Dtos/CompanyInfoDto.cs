﻿namespace PointOfSale.App.Features.Companies.Dtos;

public class CompanyInfoDto
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? NameWithId { get; set; }
    public string? Description { get; init; }
    public string? LogoPath { get; init; }
}
