using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    public class RatingEngine
    {
        Interaccion interaccion = new Interaccion();

        public decimal Rating { get; private set; }

        public void Rate()
        {
            interaccion.LogStartingRate();
            interaccion.LogLoadingPolicy();

            var policy = LoadPolicy();

            switch (policy.Type)
            {
                case PolicyType.Auto:
                    var autoPolicy = new AutoPolicy();
                    Rating = autoPolicy.CalculateRating(policy);
                    break;

                case PolicyType.Land:
                    var landPolicy = new LandPolicy();
                    Rating = landPolicy.CalculateRating(policy);
                    break;

                case PolicyType.Life:
                    var lifePolicy = new LifePolicy();
                    Rating = lifePolicy.CalculateRating(policy);
                    break;

                case PolicyType.Flood:
                    var floodPolicy = new FloodPolicy();
                    Rating = floodPolicy.CalculateRating(policy);
                    break;

                default:
                    Console.WriteLine("Unknown policy type");
                    Rating = 0;
                    break;
            }

            Console.WriteLine("Rating completed.");
        }

        private Policy LoadPolicy()
        {
            string policyJson = File.ReadAllText("policy.json");

            return JsonConvert.DeserializeObject<Policy>(policyJson,
                  new StringEnumConverter());
        }
    }
}
