using LechuRestSharp.EntityFrameworkCode;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.WebSockets;

namespace LechuRestSharp
{
    public class Consume
    {
        public static RestClient client = new
        RestClient("https://api.api-ninjas.com/v1/cars?limit=2&model=");


        public void Run()
        {
            
            Console.WriteLine("Chose a model");
            var chosenModel = Console.ReadLine();
            var url = ("https://api.api-ninjas.com/v1/cars?limit=1&model=" + chosenModel);
            RestRequest request = new RestRequest(url, Method.Get);
            request.AddHeader("X-Api-Key", "mZZh+lL5Ixl523oQQ96/bg==LBjEnWc0onSSMtH2");
            var response = client.Execute<List<String>>(request);
            //var serializedResponse = JsonConvert.SerializeObject(response.Content);
            //Console.WriteLine(serializedResponse);
            var deserializedResponse = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine("To jest wynik serialized response" + deserializedResponse);
            //var model = deserializedResponse.ToString();
            //Console.WriteLine(model);
            var model = deserializedResponse;

            //Console.WriteLine("To jest kontent ściągnięty z jakiegoś free api : " + response.Content + "\n");
            //Console.WriteLine("\njebnij coś na klawiaturze");
            Console.ReadKey();


            // seriazlization and desarialization Json
        }
    }
}

