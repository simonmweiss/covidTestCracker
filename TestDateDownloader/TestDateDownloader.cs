using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CovidTestObjects;
using Newtonsoft.Json;

namespace TestDateDownloader
{
    class TestDateDownloader
    {

        public async Task<Dictionary<string, List<TestDate>>> GetTestDates()
        {
            string url = "https://vorarlbergtestet.lwz-vorarlberg.at/GesundheitRegister/Covid/GetCovidTestLocationMassTest";

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            var locations = JsonConvert.DeserializeObject<List<Location>>(response);

            Dictionary<string, List<TestDate>> dates = new Dictionary<string, List<TestDate>>();
            foreach (Location location in locations)
            {
                var values = new Dictionary<string, string>
                {
                    { "ort", location.Key }
                };

                var content = new FormUrlEncodedContent(values);

                var response2 = await client.PostAsync("https://vorarlbergtestet.lwz-vorarlberg.at/GesundheitRegister/Covid/GetCovidTestDatesMassTest", content);

                var responseString = await response2.Content.ReadAsStringAsync();
                
                dates.Add(location.Key, JsonConvert.DeserializeObject<List<TestDate>>(responseString));

            }

            return dates;
        }
       
    }
}
