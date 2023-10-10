using System;

namespace ArdalisRating
{
    public class AutoPolicy
    {
        public decimal CalculateRating(Policy policy)
        {
            // Lógica de cálculo de calificación para AutoPolicy
            Console.WriteLine("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Console.WriteLine("Auto policy must specify Make");
                return 0;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    return 1000m;
                }
                return 900m;
            }
            // Otras lógicas de cálculo para diferentes tipos de autos
            return 0;
        }
    }
}
