using System;

namespace ArdalisRating
{
    public class LandPolicy
    {
        public decimal CalculateRating(Policy policy)
        {
            Console.WriteLine("Rating LAND policy...");
            Console.WriteLine("Validating policy.");

            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Land policy must specify Bond Amount and Valuation.");
                return 0;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Insufficient bond amount.");
                return 0;
            }
            return policy.BondAmount * 0.05m;
        }
    }
}
