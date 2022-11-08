using Visma.Loan.Domain.Calculators;

namespace Visma.Loan.Domain;

public interface IPaybackCalculatorFactory
{
    PaybackCalculator CreateCalculator(PaybackSchemeType paybackSchemeType,
        int durationInYears, decimal loanAmount, LoanType loanType);
}