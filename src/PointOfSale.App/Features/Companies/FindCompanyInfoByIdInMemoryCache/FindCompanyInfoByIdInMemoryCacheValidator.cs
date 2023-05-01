using FluentValidation;

namespace PointOfSale.App.Features.Companies.FindCompanyInfoByIdInMemoryCache;

public class FindCompanyInfoByIdInMemoryCacheValidator : AbstractValidator<FindCompanyInfoByIdInMemoryCacheQuery>
{
    public FindCompanyInfoByIdInMemoryCacheValidator()
    {
        RuleFor(query => query.CompanyId).GreaterThan(0).WithMessage("Company id should be greater than zero.");
    }
}