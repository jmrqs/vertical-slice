using PointOfSale.App.Features.Companies.Interfaces;
using PointOfSale.Core.Companies.Models;

namespace PointOfSale.Infra.Services
{
    public class CompanyInfoService : ICompanyInfoService
    {
        public Task<CompanyInfo> FindCompanyInfoByIdAsync(int companyId, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(new CompanyInfo() { Id = 1, Name =  "Company Name" });
        }
    }
}
