// See https://aka.ms/new-console-template for more information
using BanjoLoan;
using static BanjoLoan.LoanSummaryDto;

var applications = new[]
{
    new LoanApplication("C001", 10.5m),
    new LoanApplication("C001", 5_000m),
    new LoanApplication("C002", 7_000m),
    new LoanApplication(string.Empty, 800m),
    new LoanApplication("C003", -0.01m)
};

var summary = LoanSummaryCalc.CreateSummary(applications);

Console.WriteLine(summary);
