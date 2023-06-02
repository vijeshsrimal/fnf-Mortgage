using MortgageFraudsDetectionModels;
using MortgageFraudsDetectionModels.Models;

namespace Interfaces
{
    public interface IMortagageFraudService
    {
        Task<string> PurchasePower();
        Task<string> CheckMarketValue();

        Task<bool> CheckLawyerOpinion();

        //Task<IEnumerable<ValuationReport>> GetProduct();
    }
}
