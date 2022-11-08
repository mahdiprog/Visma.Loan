using Visma.Loan.Api.Requests;
using Visma.Loan.Application.Requests;
using Visma.Loan.Domain;
using Visma.Loan.Domain.SeedWork;

namespace Visma.Loan.Api.Mapping;

public static class RequestMapping
{
    public static CalculateMonthlyPaymentApplicationRequest ToApplicationRequest(this CalculateMonthlyPaymentRequest request)
    {
        return new CalculateMonthlyPaymentApplicationRequest(Enumeration.FromDisplayName<PaybackSchemeType>(request.PaybackSchemeType), request.DurationInYears, request.LoanAmount, request.LoanTypeId);
    }
    public static IEnumerable<CalculateMonthlyPaymentApplicationRequest> ToApplicationRequest(this IEnumerable<CalculateMonthlyPaymentRequest> loanTypes)
    {
        return loanTypes.Select(ToApplicationRequest);
    }
}