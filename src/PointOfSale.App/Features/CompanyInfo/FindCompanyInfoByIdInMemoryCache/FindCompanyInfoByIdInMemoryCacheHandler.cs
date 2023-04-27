using AutoMapper;
using MediatR;
using PointOfSale.App.Features.CompanyInfo.Dtos;
using PointOfSale.App.Features.CompanyInfo.Exceptions;
using PointOfSale.App.Features.CompanyInfo.Interfaces;

namespace PointOfSale.App.Features.CompanyInfo.FindCompanyInfoByIdInMemoryCache;

public class FindCompanyInfoByIdInMemoryCacheHandler : IRequestHandler<FindCompanyInfoByIdInMemoryCacheQuery, FindCompanyInfoByIdInMemoryCacheResult>
{
    private readonly IMapper _mapper;
    private readonly ICompanyInfoService _service;

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
