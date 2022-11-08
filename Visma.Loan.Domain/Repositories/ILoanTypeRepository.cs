namespace Visma.Loan.Domain.Repositories
{
    public interface ILoanTypeRepository
    {
        LoanType? GetById(int loanTypeId);
        IEnumerable<LoanType> GetAll();
    }
}
