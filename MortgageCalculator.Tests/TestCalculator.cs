using MortgageCalculator.API.Controllers;
using MortgageCalculator.API.DTO;
using MortgageCalculator.API.Enums;
using Xunit;

namespace MortgageCalculator.Tests
{
    public class TestCalculator
    {
        /**
        Test for Monthly Option
        **/
        [Fact]
        public void Test1()
        {
            //Arrange
            var Calculator = new CalculatorController();
            var data = new CalculatorDTO(300000, 5, 20, 5, PaymentSchedule.Monthly);

            //Act
            var result = Calculator.GetPaymentPerPaymentSchedule(data);

            //Assert
            double ans = 4529.1;
            Assert.Equal(ans, result.Value);
        }
        /**
        Test for Accelerated Options
        **/
        [Fact]
        public void Test2()
        {
            //Arrange
            var Calculator = new CalculatorController();
            var data = new CalculatorDTO(1000000, 10, 20, 5, PaymentSchedule.Accelerated);

            //Act
            var result = Calculator.GetPaymentPerPaymentSchedule(data);

            //Assert
            double ans = 7831.57;
            Assert.Equal(ans, result.Value);
        }

        /**
        Test for Biweekly Options
        **/
        [Fact]
        public void Test3()
        {
            //Arrange
            var Calculator = new CalculatorController();
            var data = new CalculatorDTO(1000000, 10, 20, 5, PaymentSchedule.BiWeekly);

            //Act
            var result = Calculator.GetPaymentPerPaymentSchedule(data);

            //Assert
            double ans = 8485.24;
            Assert.Equal(ans, result.Value);
        }
    }
}
