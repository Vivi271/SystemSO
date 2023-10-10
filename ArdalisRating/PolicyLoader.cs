using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

namespace ArdalisRating
{
    public class PolicyLoader
    {
        public Policy LoadPolicy()
        {
            string policyJson = File.ReadAllText("policy.json");

            return JsonConvert.DeserializeObject<Policy>(policyJson,
                  new StringEnumConverter());
        }
    }
}
