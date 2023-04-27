using AutoMapper;
using PointOfSale.App.Features.CompanyInfo.Dtos;
using PointOfSale.Core.Models.CompanyInfo;

namespace PointOfSale.App.Features.CompanyInfo;

internal class CompanyInfoMappings : Profile
{
    public CompanyInfoMappings()
    {
        CreateMap<CompanyInfoModel, CompanyInfoDto>();
    }
}    
