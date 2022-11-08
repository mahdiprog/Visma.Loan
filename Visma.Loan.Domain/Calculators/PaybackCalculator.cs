namespace Visma.Loan.Domain.Calculators;

public abstract class PaybackCalculator
{
    protected PaybackCalculator(int durationInYears, decimal loanAmount, LoanType loanType)
    {
        DurationInYears = durationInYears == 0 ?
            throw new ArgumentException("Duration should be greater then zero", nameof(durationInYears)) :
            durationInYears;
        LoanAmount = loanAmount == 0 ?
            throw new ArgumentException("Loan amount should be greater then zero", nameof(loanAmount)) :
            loanAmount;
        LoanType = loanType;
    }

    public int DurationInYears { get; }
    public decimal LoanAmount { get; }
    public LoanType LoanType { get; }
    public abstract decimal CalculateMonthlyPayback();
}