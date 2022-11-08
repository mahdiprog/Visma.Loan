using Visma.Loan.Api.Responses;
using Visma.Loan.Application.Responses;

namespace Visma.Loan.Api.Mapping;

public static class ResponseMapping
{
    public static GetLoanTypeResponse ToApiResponse(this GetLoanTypeApplicationResponse loanType)
    {
        return new GetLoanTypeResponse(loanType.Id, loanType.Name, loanType.InterestRate);
    }
    public static IEnumerable<GetLoanTypeResponse> ToApiResponse(this IEnumerable<GetLoanTypeApplicationResponse> loanTypes)
    {
        return loanTypes.Select(ToApiResponse);
    }
}