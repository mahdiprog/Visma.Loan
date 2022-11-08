using Visma.Loan.Domain.Calculators;

namespace Visma.Loan.Domain.Tests
{
    public class LinearPaybackCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 12, 0, 1)]
        [TestCase(1, 10, 0.2, 1)]
        public void Calculate_ShouldReturnCorrectValue(int duration, decimal loanAmount, decimal interest, decimal payback)
        {
            // Arrange
            var loanType = new LoanType(1, "Test", interest);
            var calculator = new LinearPaybackCalculator(duration, loanAmount, loanType);
            // Act
            var result = calculator.CalculateMonthlyPayback();
            // Assert
            Assert.That(result, Is.EqualTo(payback));
        }

        [Test]
        public void Calculate_WhenDurationIsZero_ThrowsException()
        {
            // Arrange
            var loanType = new LoanType(1, "Test", 0.1m);
            // Act and Assert
            Assert.Throws<ArgumentException>(() => new LinearPaybackCalculator(0, 10, loanType));
        }

        [Test]
        public void Calculate_WhenAmountIsZero_ThrowsException()
        {
            // Arrange
            var loanType = new LoanType(1, "Test", 0.1m);
            // Act and Assert
            Assert.Throws<ArgumentException>(() => new LinearPaybackCalculator(10, 0, loanType));
        }
    }
}