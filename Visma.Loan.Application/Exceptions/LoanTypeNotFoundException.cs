namespace Visma.Loan.Application.Exceptions;

public class LoanTypeNotFoundException : Exception
{
    public LoanTypeNotFoundException(int loanTypeId) : base($"Loan type with Id {loanTypeId} not found")
    {
    }

    public LoanTypeNotFoundException(string message)
        : base(message)
    { }

    public LoanTypeNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    { }
}
