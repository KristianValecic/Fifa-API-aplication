using Lib.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dal
{
    class Repository : IRepository
    {

        public Task<T> GetOfflineDataAsync<T>(string endpoint)
        {
            return Task.Run(async () =>
            {
                return JsonConvert.DeserializeObject<T>(endpoint);
            });
        }

        public Task<T> GetOnlineDataAsync<T>(string endpoint)
        {
            return Task.Run(async () =>
            {
                var apiClient = new RestClient(endpoint);
                var apiResult = await apiClient.ExecuteAsync<T>(new RestRequest());


                return JsonConvert.DeserializeObject<T>(apiResult.Content);
            });
        }
    }
}
