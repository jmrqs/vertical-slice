using Microsoft.AspNetCore.Mvc;
using PointOfSale.App.Features.Companies.FindCompanyByIdInMemoryCache;
using PointOfSale.BuildingBlocks.WebApi;

namespace PointOfSale.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompaniesController : ApiControllerBase
{
    [HttpGet("{id:int}/memory-cache")]
    public async Task<ActionResult> FindCompanyByIdInMemoryCacheAsync([FromRoute] int id,
        CancellationToken cancellationToken = default)
    {
        var query = new FindCompanyByIdInMemoryCacheQuery(id);

        var result = await Mediator.Send(query, cancellationToken);
        return Ok(result);
    }
}
