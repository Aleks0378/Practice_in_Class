using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_10
{
    internal class Program
    {
        public static async void GetData()
        {
            double sum = GiveMoney();
            string url = @"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri(url));
            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                List<Currency> data = JsonConvert.DeserializeObject<List<Currency>>(jsonContent);
                foreach (Currency currency in data)
                {
                    if (currency.r030==840.ToString())
                    {
                        Console.WriteLine( sum / currency.rate);
                    }
                    //Console.WriteLine($"{currency.r030} {currency.cc} {currency.rate}");
                }
            }
        }

        public static double GiveMoney()
        {
            Console.WriteLine("Сума у гривнях: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            GetData();
            Console.ReadLine();
        }
    }
}
