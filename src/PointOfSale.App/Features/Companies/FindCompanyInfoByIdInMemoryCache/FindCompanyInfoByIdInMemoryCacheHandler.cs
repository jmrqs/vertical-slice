using MapsterMapper;
using MediatR;
using PointOfSale.App.Features.Companies.Dtos;
using PointOfSale.App.Features.Companies.Exceptions;
using PointOfSale.App.Features.Companies.Interfaces;

namespace PointOfSale.App.Features.Companies.FindCompanyInfoByIdInMemoryCache;

public class FindCompanyInfoByIdInMemoryCacheHandler : IRequestHandler<FindCompanyInfoByIdInMemoryCacheQuery, FindCompanyInfoByIdInMemoryCacheResult>
{
    private readonly ICompanyInfoService _service;
    private readonly IMapper _mapper;


    public FindCompanyInfoByIdInMemoryCacheHandler(ICompanyInfoService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<FindCompanyInfoByIdInMemoryCacheResult> Handle(FindCompanyInfoByIdInMemoryCacheQuery query, CancellationToken cancellationToken)
    {
        var companyInfo = 
            await _service.FindCompanyInfoByIdAsync(query.CompanyId, cancellationToken)
            ?? throw new CompanyInfoNotFoundException(query.CompanyId);
        
        var result = _mapper.Map<CompanyInfoDto>(companyInfo);

        return new FindCompanyInfoByIdInMemoryCacheResult { CompanyInfo = result };
    }
}
