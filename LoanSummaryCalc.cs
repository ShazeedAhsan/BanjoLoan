using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BanjoLoan.LoanSummaryDto;

namespace BanjoLoan
{
    public static class LoanSummaryCalc
    {
        public static LoanSummary CreateSummary(IEnumerable<LoanApplication> applications)
        {
            if (!applications.Any())
            {
                return new LoanSummary(0, 0, 0, 0);
            }

            int totalApplications = 0;
            decimal totalLoanAmount = 0;
            HashSet<string> customerIds = new HashSet<string>();
            foreach (var application in applications) 
            {
                if (!string.IsNullOrWhiteSpace(application.CustomerId))
                { 
                    totalApplications++;
                    customerIds.Add(application.CustomerId);
                    totalLoanAmount = totalLoanAmount + application.Amount;
                }
            }
            decimal avgAmount = Math.Round((totalLoanAmount / totalApplications), 2);
            return new LoanSummary(totalApplications, customerIds.Count, totalLoanAmount, avgAmount);
        }
    }
}
