namespace Visma.Loan.Domain.Calculators;

public class LinearPaybackCalculator : PaybackCalculator
{
    public LinearPaybackCalculator(int durationInYears, decimal loanAmount, LoanType loanType) : base(durationInYears, loanAmount, loanType)
    {
    }
    public override decimal CalculateMonthlyPayback()
    {
        var interestAmount = DurationInYears * LoanAmount * LoanType.InterestRate;
        var paybackAmount = LoanAmount + interestAmount;

        return paybackAmount / (DurationInYears * 12);
    }
}