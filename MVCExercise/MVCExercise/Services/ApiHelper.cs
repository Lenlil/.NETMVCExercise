using MVCExercise.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace MVCExercise.Services
{
    public class ApiHelper
    {
        private static readonly ApiHelper instance = new ApiHelper();
        static ApiHelper()
        {
        }

        private ApiHelper()
        {
        }

        public static ApiHelper Instance
        {
            get
            {
                return instance;
            }
        } 

        public dynamic MakeApiCallSync(string url)
        {
            List<Color> colorList = new List<Color>();

            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync(url).Result)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    var jsonRootObject = JsonConvert.DeserializeObject<RootObject>(apiResponse);
                    colorList = jsonRootObject.Data.ToList();
                    return colorList;
                }
            }         
        }
    }
}
