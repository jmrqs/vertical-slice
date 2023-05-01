using FluentValidation;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PointOfSale.App;
using PointOfSale.App.Features.Companies.Interfaces;
using PointOfSale.BuildingBlocks.FluentValidation;
using PointOfSale.Infra.Services;

namespace PointOfSale.Infra;

public static class Extensions
{
    public static WebApplicationBuilder AddInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ICompanyInfoService, CompanyInfoService>();

        builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

        builder.Services.AddValidatorsFromAssembly(typeof(ApplicationRoot).Assembly);

        builder.Services.AddMediatR(config => config
            .RegisterServicesFromAssembly(typeof(ApplicationRoot).Assembly));

        var typeAdapterConfig = TypeAdapterConfig.GlobalSettings;
        typeAdapterConfig.Scan(typeof(ApplicationRoot).Assembly);

        var mapperConfig = new Mapper(typeAdapterConfig);
        builder.Services.AddSingleton<IMapper>(mapperConfig);

        return builder;
    }
}
