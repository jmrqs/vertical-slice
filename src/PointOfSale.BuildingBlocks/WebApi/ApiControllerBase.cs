using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace PointOfSale.BuildingBlocks.WebApi;

[ApiController]
public abstract class ApiControllerBase : ControllerBase
{
    private IMapper? _mapper;

    private ISender? _mediator;
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>()!;

    protected IMapper Mapper => _mapper ??= HttpContext.RequestServices.GetService<IMapper>()!;
}
