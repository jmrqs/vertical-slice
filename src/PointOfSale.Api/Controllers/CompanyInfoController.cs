using Microsoft.AspNetCore.Mvc;
using PointOfSale.App.Features.Companies.FindCompanyInfoByIdInMemoryCache;
using PointOfSale.BuildingBlocks.WebApi;

namespace PointOfSale.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyInfoController : ApiControllerBase
{
    [HttpGet("{id:int}/memory-cache")]
    public async Task<ActionResult> FindCompanyInfoByIdInMemoryCacheAsync([FromRoute] int id,
        CancellationToken cancellationToken = default)
    {
        var query = new FindCompanyInfoByIdInMemoryCacheQuery(id);

        var result = await Mediator.Send(query, cancellationToken);
        return Ok(result);
    }
}
