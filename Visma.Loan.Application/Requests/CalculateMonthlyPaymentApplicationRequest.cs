using Visma.Loan.Domain;

namespace Visma.Loan.Application.Requests;

public record CalculateMonthlyPaymentApplicationRequest(PaybackSchemeType PaybackSchemeType,
    int DurationInYears, decimal LoanAmount, int LoanTypeId);