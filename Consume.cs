using LechuRestSharp.EntityFrameworkCode;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.WebSockets;
using System.Reflection.PortableExecutable;

namespace LechuRestSharp
{
    public class Consume
    {

        protected Cars cars;

        public static RestClient client = new
        RestClient("https://api.api-ninjas.com/v1/cars?limit=2&model=");

        /*            var deserializedResponse = JsonConvert.DeserializeObject(response.Content);
            var serializedResponse = JsonConvert.SerializeObject(response.Content);*/

        public Cars Run()
        {

            cars = null;
            List<Cars> carsList = new List<Cars>();

            Console.WriteLine("Chose a model");
            var chosenModel = Console.ReadLine();
            var url = ("https://api.api-ninjas.com/v1/cars?limit=1&model=" + chosenModel);

            RestRequest request = new RestRequest(url, Method.Get);
            request.AddHeader("X-Api-Key", "mZZh+lL5Ixl523oQQ96/bg==LBjEnWc0onSSMtH2");
            var response = client.Execute<List<String>>(request);

            Console.WriteLine("To jest kontent ściągnięty z jakiegoś free api : " + response.Content + "\n");

            cars = JsonConvert.DeserializeObject<Cars>(response.Content.Trim(new Char[] { '[', ']' }));

            Console.WriteLine("To jest wynik deserialized response       " + cars.model);

            Console.WriteLine("\njebnij coś na klawiaturze");
            Console.ReadKey();

            return cars;
        }
    }
}