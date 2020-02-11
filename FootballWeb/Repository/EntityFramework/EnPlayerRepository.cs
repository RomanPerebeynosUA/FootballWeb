using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballWeb.Data;
using FootballWeb.Models.Entity;
using FootballWeb.Repository;

namespace FootballWeb.Repository.EntityFramework
{
    public class EnPlayerRepository : IRepository<Player>
    {
        private readonly AppDBContext context;

        public EnPlayerRepository(AppDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Player> GetAll()
        {
            return context.Players.ToList();
        }
        

        public void Add(Player item)
        {
            context.Players.Add(item);
            context.SaveChanges();
        }

        public void Delete(Player item)
        {
            throw new NotImplementedException();
        }

        public Player GetById(int id)
        {
            return context.Players.FirstOrDefault(p =>p.Id == id);
        }

        public void Update(Player item)
        {
            throw new NotImplementedException();
        }
    }
}
