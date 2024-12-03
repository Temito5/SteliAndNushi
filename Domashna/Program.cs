using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Domashna
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string content = await client.GetStringAsync(url); 
                    Console.WriteLine("Получени данни от уебсайта:");
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка при изтегляне на съдържанието: {ex.Message}");
            }
        }
    }
}
