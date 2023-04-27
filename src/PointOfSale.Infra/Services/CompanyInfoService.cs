using PointOfSale.App.Features.CompanyInfo.Interfaces;
using PointOfSale.Core.Models.CompanyInfo;

namespace PointOfSale.Infra.Services
{
    internal class CompanyInfoService : ICompanyInfoService
    {
        public Task<CompanyInfoModel> FindCompanyInfoByIdAsync(int companyId, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(new CompanyInfoModel() { Id = 1, Name =  "Company Name" }); // TODO: Database integration
        }
    }
}
