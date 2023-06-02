using Interfaces;
using MortgageFraudContexts;
using Services;
using System.Runtime.InteropServices;

namespace Services
{
    public class MortgageFraudService : IMortagageFraudService
    {
        public async Task<string> PurchasePower()
        {
            string result = "";
            double perMonthSalary = 50000;
            double mortgageLoanRequested = 3600000;

            double ProximateResult = perMonthSalary * 0.40 * 15 * 12;
            double UppermortgageLoanRequested = mortgageLoanRequested + 200000;
            double lowermortgageLoanRequested = mortgageLoanRequested - 200000;
            if (ProximateResult >= lowermortgageLoanRequested && ProximateResult <= UppermortgageLoanRequested)
                result = "Yellow";

            if (ProximateResult > UppermortgageLoanRequested)
                result = "Green";

            if (ProximateResult < lowermortgageLoanRequested)
                result = "Green";

            return result;
        }

        public async Task<string> CheckMarketValue()
        {

            decimal marketValue = 700000;
            decimal quotedAmount = 1000000;
            decimal bankOffer = marketValue * 1.7m;
            string color = quotedAmount > bankOffer ? "Red" : "Green";
            return color;
        }
        
        public async Task<bool> CheckLawyerOpinion()
        {
            string lawyer_opinion = "Approved";

            if (lawyer_opinion == "Approved")
                return true;
            else
                return false;
        }
    }
}
