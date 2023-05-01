using Microsoft.AspNetCore.Mvc.ApplicationModels;
using PointOfSale.App;
using PointOfSale.BuildingBlocks.WebApi;
using PointOfSale.Infra;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.AddInfrastructure();

builder.Services.AddControllers(options =>
    options.Conventions.Add(new RouteTokenTransformerConvention(new SlugApiParameters())));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
