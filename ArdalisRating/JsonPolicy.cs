using ArdalisRating;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.IO;

public class JsonPolicy
{
    public Policy LoadPolicy()
    {
        string policyJson = File.ReadAllText("policy.json");

        return JsonConvert.DeserializeObject<Policy>(policyJson,
              new StringEnumConverter());
    }
}
