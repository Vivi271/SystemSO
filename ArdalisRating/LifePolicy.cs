﻿using System;

namespace ArdalisRating
{
    public class LifePolicy
    {
        public decimal CalculateRating(Policy policy)
        {
            // Lógica de cálculo de calificación para LifePolicy
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("Life policy must include Date of Birth.");
                return 0;
            }
            if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                Console.WriteLine("Centenarians are not eligible for coverage.");
                return 0;
            }
            if (policy.Amount == 0)
            {
                Console.WriteLine("Life policy must include an Amount.");
                return 0;
            }
            int age = DateTime.Today.Year - policy.DateOfBirth.Year;
            if (policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < policy.DateOfBirth.Day ||
                DateTime.Today.Month < policy.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = policy.Amount * age / 200;
            if (policy.IsSmoker)
            {
                return baseRate * 2;
            }
            return baseRate;
        }
    }
}
