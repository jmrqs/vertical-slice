using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PointOfSale.App.Features.Companies.FindCompanyByIdInMemoryCache;
using PointOfSale.App.Interfaces;
using PointOfSale.BuildingBlocks.FluentValidation;
using PointOfSale.Infra.Services;

namespace PointOfSale.Infra;

public static class Extensions
{
    public static WebApplicationBuilder AddInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ICompanyService, CompanyService>();

        builder.Services.AddValidatorsFromAssemblyContaining<FindCompanyByIdInMemoryCacheValidator>();

        builder.Services.AddMediatR(config => config
            .RegisterServicesFromAssemblyContaining<FindCompanyByIdInMemoryCacheHandler>())
            .AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


        return builder;
    }
}
