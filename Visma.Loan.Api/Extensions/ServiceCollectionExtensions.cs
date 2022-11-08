using Visma.Loan.Application;
using Visma.Loan.Domain;
using Visma.Loan.Domain.Repositories;
using Visma.Loan.Infrastructure.Repositories;

namespace Visma.Loan.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddScoped<ILoanTypeRepository, LoanTypeRepository>();

            services.AddScoped<IPaybackCalculatorFactory, PaybackCalculatorFactory>();

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ILoanService, LoanService>();

            return services;
        }
    }
}
