using Visma.Loan.Domain.SeedWork;

namespace Visma.Loan.Domain;

public class LoanType : Entity
{
    public LoanType(string name, decimal interestRate)
    {
        SetName(name);
        SetInterestRate(interestRate);
    }
    public LoanType(int id, string name, decimal interestRate)
    {
        Id = id;
        SetName(name);
        SetInterestRate(interestRate);
    }

    public override int Id { get; protected set; }
    public string Name { get; private set; }
    public decimal InterestRate { get; private set; }

    void SetName(string name)
    {
        Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
    }
    void SetInterestRate(decimal interestRate)
    {
        InterestRate = interestRate;
    }
}
