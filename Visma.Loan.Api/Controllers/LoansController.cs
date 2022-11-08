using Microsoft.AspNetCore.Mvc;
using Visma.Loan.Api.Mapping;
using Visma.Loan.Api.Requests;
using Visma.Loan.Api.Responses;
using Visma.Loan.Application;

namespace Visma.Loan.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LoansController : ControllerBase
{
    private readonly ILogger<LoansController> _logger;
    private readonly ILoanService _loanService;

    public LoansController(ILogger<LoansController> logger, ILoanService loanService)
    {
        _logger = logger;
        _loanService = loanService;
    }

    [HttpGet]
    public IEnumerable<GetLoanTypeResponse> GetLoanTypes()
    {
        return _loanService.GetLoanTypes().ToApiResponse();
    }

    [HttpPost("calculate")]
    public decimal CalculateMonthlyPayment(CalculateMonthlyPaymentRequest request)
    {
        return _loanService.CalculateMonthlyPayment(request.ToApplicationRequest());
    }
}