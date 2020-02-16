using FootballWeb.ConnectionAPI.Interfaces;
using FootballWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FootballWeb.ConnectionAPI.Repositories
{
    public  class PlayerApi : IRepositoryApi<Player>
    {
        public  async Task<Player> GetEntityAsync(string path, HttpClient client )
        {
            Player player = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                player = await response.Content.ReadAsAsync<Player>();
            }
            return player;
        }
    }
}
