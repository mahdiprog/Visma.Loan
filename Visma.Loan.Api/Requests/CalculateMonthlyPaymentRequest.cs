namespace Visma.Loan.Api.Requests;

public record CalculateMonthlyPaymentRequest(string PaybackSchemeType,
    int DurationInYears, decimal LoanAmount, int LoanTypeId);