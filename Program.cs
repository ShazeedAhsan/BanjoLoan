// See https://aka.ms/new-console-template for more information
using BanjoLoan;
using static BanjoLoan.LoanSummaryDto;

Console.WriteLine("Hello, World!");
var applications = new[]
{
    new LoanApplication("C001", 1000m),
    new LoanApplication("C002", 2000m),
    new LoanApplication("C001", 1500m)
};

var summary = LoanSummaryCalc.CreateSummary(applications);

Console.WriteLine(summary);
