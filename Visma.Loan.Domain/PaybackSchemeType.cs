using Visma.Loan.Domain.SeedWork;

namespace Visma.Loan.Domain;

public class PaybackSchemeType : Enumeration
{
    public static PaybackSchemeType Linear = new(1, nameof(Linear).ToLowerInvariant());
    public PaybackSchemeType(int id, string name) : base(id, name)
    {
    }
}