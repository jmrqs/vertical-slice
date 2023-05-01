namespace PointOfSale.App.Features.Companies.Interfaces
{
    public interface ICompanyInfoService
    {
        Task<Core.Companies.Models.CompanyInfo> FindCompanyInfoByIdAsync(int companyId, CancellationToken cancellationToken = default);
    }
}
