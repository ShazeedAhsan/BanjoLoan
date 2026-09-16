using static BanjoLoan.LoanSummaryDto;

namespace BanjoLoan
{
    public static class LoanSummaryCalc
    {
        public static LoanSummary CreateSummary(IEnumerable<LoanApplication> applications)
        {
            if (applications == null || !applications.Any())
            {
                return new LoanSummary(0, 0, 0, 0);
            }

            int totalApplications = 0;
            decimal totalLoanAmount = 0;
            HashSet<string> customerIds = new HashSet<string>();
            foreach (var application in applications) 
            {
                try 
                {
                    if (string.IsNullOrWhiteSpace(application.CustomerId))
                        throw new ArgumentException("Customer id not found. Application has not been included in Summary Calculation.");
                    if (application.Amount < 0)
                        throw new ArgumentException("Invalid Loan amount. Application has not been included in Summary Calculation.");

                    totalApplications++;
                    customerIds.Add(application.CustomerId);
                    totalLoanAmount = totalLoanAmount + application.Amount;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            decimal avgAmount = totalApplications == 0 ? 0 : Math.Round((totalLoanAmount / totalApplications), 2);
            return new LoanSummary(totalApplications, customerIds.Count, totalLoanAmount, avgAmount);
        }
    }
}
