using Visma.Loan.Domain;
using Visma.Loan.Domain.Repositories;

namespace Visma.Loan.Infrastructure.Repositories;

public class LoanTypeRepository : ILoanTypeRepository
{
    public LoanType? GetById(int loanTypeId)
    {
        return GetAll().FirstOrDefault(l => l.Id == loanTypeId);
    }

    public IEnumerable<LoanType> GetAll()
    {
        yield return new LoanType(1, "Housing Loan", 0.035m);
    }
}