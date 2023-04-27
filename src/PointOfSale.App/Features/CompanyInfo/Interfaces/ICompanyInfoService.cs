using PointOfSale.Core.Models.CompanyInfo;

namespace PointOfSale.App.Features.CompanyInfo.Interfaces
{
    public interface ICompanyInfoService
    {
        Task<CompanyInfoModel> FindCompanyInfoByIdAsync(int companyId, CancellationToken cancellationToken = default);
    }
}
