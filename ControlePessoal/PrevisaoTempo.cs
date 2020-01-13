using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace ControlePessoal
{
    public class PrevisaoTempo
    {
        public WeatherInfo.RootObject getWeather(string city_name)
        {
            string key = "sua key"; 
            string url = string.Format("https://api.hgbrasil.com/weather?key={0}&city_name={1}&format=json", key, city_name);
            WebClient web = new WebClient();
            var json = web.DownloadString(url);
            byte[] bytes = Encoding.Default.GetBytes(json);
            json = Encoding.UTF8.GetString(bytes);
            var result = JsonConvert.DeserializeObject<WeatherInfo.RootObject>(json);
            WeatherInfo.RootObject outPut = result;

            return result;

        }
    }
}
