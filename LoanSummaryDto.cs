using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanjoLoan
{
    public class LoanSummaryDto
    {
        public record LoanApplication (string CustomerId, decimal Amount);
        public record LoanSummary(
            int ApplicationCount,
            int CustomerCount,
            decimal TotalAmount,
            decimal AverageAmount);
        }
}
