using System;
using System.ComponentModel.DataAnnotations;

namespace MortgageCalculator.API.DTO
{
    public class CalculatorDTO
    {
        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public double PropertyPrice { get; set; }

        [Required]
        [Range(0.0, 100.1, ErrorMessage = "The field {0} must be greater than {1}, but less than or equal to {2}.")]
        public double AnnualInterestRate { get; set; }

        [Required]
        [Range(0.0, 100.1, ErrorMessage = "The field {0} must be greater than {1}, but less than or equal to {2}.")]
        public double DownPaymentRate { get; set; }

        [Required]
        [Range(4, 30, ErrorMessage = "The field {0} must be greater than {1}, but less than or equal to {2}.")]
        public int AmortizationPeriod { get; set; }
    }
}