using System;
using System.ComponentModel.DataAnnotations;
using MortgageCalculator.API.Enums;

namespace MortgageCalculator.API.DTO
{
    public class CalculatorDTO
    {
        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        /// <example>300000</example>  
        public double PropertyPrice { get; set; }

        [Required]
        [Range(0.1, 100, ErrorMessage = "The field {0} must be between {1} and {2}")]
        /// <example>5</example>  
        public double AnnualInterestRate { get; set; }

        [Required]
        [Range(5, 100, ErrorMessage = "The field {0} must be between {1} and {2}")]
        /// <example>5</example>  
        public double DownPaymentRate { get; set; }

        [Required]
        [Range(5, 30, ErrorMessage = "The field {0} must be between {1} and {2}")]
        /// <example>5</example>  
        public int AmortizationPeriod { get; set; }

        [Required]
        [EnumDataType(typeof(PaymentSchedule))]
        /// <example>24</example>  
        public PaymentSchedule PaymentScheduleOptions { get; set; }
    }
}