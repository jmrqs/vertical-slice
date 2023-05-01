using Mapster;
using PointOfSale.App.Features.Companies.Dtos;
using PointOfSale.Core.Companies.Models;

namespace PointOfSale.App.Features.Companies;

public class CompaniesMappings : IRegister
{
    void IRegister.Register(TypeAdapterConfig config)
    {
        config.NewConfig<CompanyInfo, CompanyInfoDto>()
            .Map(dest => dest.NameWithId, src => $"{src.Id} - {src.Name}");
    }
}
