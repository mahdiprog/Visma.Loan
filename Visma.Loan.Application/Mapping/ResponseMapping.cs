using Visma.Loan.Application.Responses;
using Visma.Loan.Domain;

namespace Visma.Loan.Application.Mapping;

public static class ResponseMapping
{
    public static GetLoanTypeApplicationResponse ToApplicationResponse(this LoanType loanType)
    {
        return new GetLoanTypeApplicationResponse(loanType.Id, loanType.Name, loanType.InterestRate);
    }
    public static IEnumerable<GetLoanTypeApplicationResponse> ToApplicationResponse(this IEnumerable<LoanType> loanTypes)
    {
        return loanTypes.Select(ToApplicationResponse);
    }
}