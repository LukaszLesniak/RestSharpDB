using RestSharp;

namespace LechuRestSharp
{
    public class Consume
    {
        public static RestClient client = new
        RestClient("https://restcountries.com/v3.1/name/poland");
        
        public void Run()
        {
            var url = "https://restcountries.com/v3.1/name/poland";
            RestRequest request = new RestRequest(url, Method.Get);
            var response = client.Execute<List<String>>(request);
            Console.WriteLine("To jest kontent ściągnięty z jakiegoś free api : " + response.Content + "\n");
            Console.WriteLine("\njebnij coś na klawiaturze");
            Console.ReadKey();
        }
    }
}

