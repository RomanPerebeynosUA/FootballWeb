using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FootballWeb.ConnectionAPI.Interfaces
{
   public  interface IRepositoryApi<T> where T : IEntity
    {
        Task<T> GetEntityAsync(string path, HttpClient client);

    }
}
