using FootballWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FootballWeb.ConnectionAPI
{
    public static class Connection
    {
        public  static void ConnectionToApi(HttpClient Client)
        {
            Client.BaseAddress = new Uri("https://api.football-data.org/v2/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Add("X-Auth-Token", "514db4ae08de4e0e97a020ed38b7bc51");
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }     
}
}
