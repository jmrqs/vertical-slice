using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PointOfSale.App;
using PointOfSale.App.Features.CompanyInfo.FindCompanyInfoByIdInMemoryCache;
using PointOfSale.App.Features.CompanyInfo.Interfaces;
using PointOfSale.BuildingBlocks.FluentValidation;
using PointOfSale.Infra.Services;
using System.Reflection;

namespace PointOfSale.Infra;

public static class Extensions
{
    public static WebApplicationBuilder AddInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ICompanyInfoService, CompanyInfoService>();

        builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

        builder.Services.AddValidatorsFromAssemblyContaining<FindCompanyInfoByIdInMemoryCacheValidator>();

        builder.Services.AddMediatR(config => config
            .RegisterServicesFromAssemblyContaining<FindCompanyInfoByIdInMemoryCacheHandler>())
            .AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


        return builder;
    }
}
