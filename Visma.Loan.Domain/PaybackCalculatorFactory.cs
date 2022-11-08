using Visma.Loan.Domain.Calculators;

namespace Visma.Loan.Domain
{
    public class PaybackCalculatorFactory : IPaybackCalculatorFactory
    {
        public PaybackCalculator CreateCalculator(PaybackSchemeType paybackSchemeType,
            int durationInYears, decimal loanAmount, LoanType loanType)
        {
            if (paybackSchemeType == PaybackSchemeType.Linear)
            {
                return new LinearPaybackScheme(durationInYears, loanAmount, loanType);
            }

            throw new ArgumentException(
                $"Can not create calculator for Scheme \"{paybackSchemeType}\"",
                nameof(paybackSchemeType));
        }
    }
}
