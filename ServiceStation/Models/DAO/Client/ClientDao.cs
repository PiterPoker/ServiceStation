using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ServiceStation.Models.DAO.Client
{
    public class ClientDao : IClientDao
    {
        public void Add(Entity.Client client)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Client.Add(client);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var item = context.Client.Find(id);
                if (item != null)
                {
                    context.Client.Remove(item);
                }

                context.SaveChanges();
            }
        }

        public void Edit(Entity.Client client)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(client).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Entity.Client Get(int id)
        {
            Entity.Client client;
            using (var context = new ApplicationDbContext())
            {
                client = context.Client.FirstOrDefault(c => c.Id == id);
            }
            return client;
        }

        public List<Entity.Client> Load()
        {
            List<Entity.Client> clent;
            using (var context = new ApplicationDbContext())
            {
                clent = context.Client.ToList();
            }
            return clent;
        }
    }
}