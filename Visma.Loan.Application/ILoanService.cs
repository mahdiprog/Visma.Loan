using Visma.Loan.Application.Requests;
using Visma.Loan.Application.Responses;

namespace Visma.Loan.Application;

public interface ILoanService
{
    IEnumerable<GetLoanTypeApplicationResponse> GetLoanTypes();
    decimal CalculateMonthlyPayment(CalculateMonthlyPaymentApplicationRequest request);
}