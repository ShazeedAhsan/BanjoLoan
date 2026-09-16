# BanjoLoan


## Build the solution

From the solution root, run:

```
dotnet restore
dotnet build
```

## Run Tests
```
dotnet test
```


## Assumptions made

LoanSummaryCalc.CreateSummary returns a summary with a default zero values when the input collection is null or empty.
Applications with empty or null CustomerId would be excluded from summary calculation.
Applications with negative amounts would be excluded from summary calculation.
Invalid applications are taken out of the summary calculation and processing of other valid applications countinues.


## Improvements

Logging instead of Console.Writeline
Add a LoanID to LoanApplication
Add more unit tests