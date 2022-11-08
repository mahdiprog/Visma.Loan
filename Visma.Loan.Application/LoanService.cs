using Visma.Loan.Application.Exceptions;
using Visma.Loan.Application.Mapping;
using Visma.Loan.Application.Requests;
using Visma.Loan.Application.Responses;
using Visma.Loan.Domain;
using Visma.Loan.Domain.Repositories;

namespace Visma.Loan.Application
{
    public class LoanService : ILoanService
    {
        private readonly IPaybackCalculatorFactory _paybackCalculatorFactory;
        private readonly ILoanTypeRepository _loanTypeRepository;

        public LoanService(IPaybackCalculatorFactory paybackCalculatorFactory, ILoanTypeRepository loanTypeRepository)
        {
            _paybackCalculatorFactory = paybackCalculatorFactory;
            _loanTypeRepository = loanTypeRepository;
        }

        public decimal CalculateMonthlyPayment(CalculateMonthlyPaymentApplicationRequest request)
        {
            var loanType = _loanTypeRepository.GetById(request.LoanTypeId);
            if (loanType == null)
            {
                throw new LoanTypeNotFoundException(request.LoanTypeId);
            }

            var calculator = _paybackCalculatorFactory.CreateCalculator(request.PaybackSchemeType,
                request.DurationInYears, request.LoanAmount, loanType);
            return calculator.CalculateMonthlyPayback();
        }
        public IEnumerable<GetLoanTypeApplicationResponse> GetLoanTypes()
        {
            return _loanTypeRepository.GetAll().ToApplicationResponse();
        }
    }
}
