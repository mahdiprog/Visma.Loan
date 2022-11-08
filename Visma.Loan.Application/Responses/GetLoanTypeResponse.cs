namespace Visma.Loan.Application.Responses;

public record GetLoanTypeApplicationResponse(int Id, string Name, decimal InterestRate);