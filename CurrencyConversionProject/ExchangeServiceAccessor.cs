using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

/*
 * Class ExchangeServiceAccessor is a class designed to get and deserialize JSON data from online. The website's URL
 * is passed to the constructor.
 */
namespace CurrencyConversionProject
{
    public class ExchangeServiceAccessor
    {
        public string Url { get; }
        public ExchangeServiceAccessor(string url)
        {
            Url = url;
        }

        //Method deserializeJson() is a generic method that tries to deserializes JSON data as the data type specified
        //when the method is called.
        public T deserializeJson<T>() where T : new()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string jsonData = webClient.DownloadString(Url);
                    return !string.IsNullOrEmpty(jsonData) ? JsonConvert.DeserializeObject<T>(jsonData) : new T();
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
    }
}
