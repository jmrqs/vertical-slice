using PointOfSale.BuildingBlocks.MediatR;

namespace PointOfSale.App.Features.Companies.FindCompanyInfoByIdInMemoryCache;

public class FindCompanyInfoByIdInMemoryCacheQuery : IQuery<FindCompanyInfoByIdInMemoryCacheResult>
{
    public FindCompanyInfoByIdInMemoryCacheQuery(int companyId)
    {
        CompanyId = companyId;
    }

    public int CompanyId { get; set; }
}
