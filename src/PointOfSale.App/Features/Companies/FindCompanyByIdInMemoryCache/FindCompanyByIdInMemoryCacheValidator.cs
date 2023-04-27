using FluentValidation;

namespace PointOfSale.App.Features.Companies.FindCompanyByIdInMemoryCache;

public class FindCompanyByIdInMemoryCacheValidator : AbstractValidator<FindCompanyByIdInMemoryCacheQuery>
{
    public FindCompanyByIdInMemoryCacheValidator()
    {
        RuleFor(query => query.CompanyId).GreaterThan(0).WithMessage("Company id should be greater than zero");
    }
}