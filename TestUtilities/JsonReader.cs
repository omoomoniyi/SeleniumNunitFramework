using Newtonsoft.Json.Linq;
using System.IO;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace SeleniumNunitFramework.TestUtilities
{
    public class JsonReader
    {
        public string GetTestData(string tokenKey)
        {
            string file = ConfigurationManager.AppSettings["testDataFilePath"];
            string JsonFile = File.ReadAllText(file);
            //Helps to read all Json file from "TestData/LoginTestData"

            var JsonObject = JToken.Parse(JsonFile); //Helps to pick the each object from the "TestData/LoginTestData"

            return JsonObject.SelectToken(tokenKey).Value<string>(); 

        }
    }
}
