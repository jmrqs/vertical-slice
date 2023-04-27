using AutoMapper;
using MediatR;
using PointOfSale.App.Interfaces;

namespace PointOfSale.App.Features.Companies.FindCompanyByIdInMemoryCache;

public class FindCompanyByIdInMemoryCacheHandler : IRequestHandler<FindCompanyByIdInMemoryCacheQuery, FindCompanyByIdInMemoryCacheResult>
{
    private readonly IMapper _mapper;
    private readonly ICompanyService _service;

    public FindCompanyByIdInMemoryCacheHandler(ICompanyService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public Task<FindCompanyByIdInMemoryCacheResult> Handle(FindCompanyByIdInMemoryCacheQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
