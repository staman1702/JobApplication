using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TecajAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProsjecanTecajHrkUsdAsync().Wait();
        }

        static async Task ProsjecanTecajHrkUsdAsync()
        {
            double sum = 0;
            double avrgRate;

            for (int i = 0; i >= -4; i--)
            {
                using (var client = new HttpClient())
                {

                    string date = DateTime.Now.AddDays(i).ToString("yyyy-MM-dd");
                    string ext = date + "?base=HRK";

                    client.BaseAddress = new Uri("https://api.exchangeratesapi.io/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept
                        .Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(ext);

                    if (response.IsSuccessStatusCode)
                    {
                        RootObject root = await response.Content.ReadAsAsync<RootObject>();
                        sum += root.rates.USD;
                    }

                }
            }

            avrgRate = sum / 5;

            Console.WriteLine("According to https://api.exchangeratesapi.io," +
                " \naverage HRK rate in past 5 days is {0} USD.", avrgRate);
        }
    }
}
