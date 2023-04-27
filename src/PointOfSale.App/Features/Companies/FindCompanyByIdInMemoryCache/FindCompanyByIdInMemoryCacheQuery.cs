using MediatR;
using PointOfSale.App.Dtos;
using PointOfSale.BuildingBlocks.MediatR;

namespace PointOfSale.App.Features.Companies.FindCompanyByIdInMemoryCache;

public class FindCompanyByIdInMemoryCacheQuery : IQuery<FindCompanyByIdInMemoryCacheResult>
{
    public FindCompanyByIdInMemoryCacheQuery(int companyId)
    {
        CompanyId = companyId;
    }

    public int CompanyId { get; set; }
}
