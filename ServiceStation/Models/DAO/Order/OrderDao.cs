using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ServiceStation.Models.DAO.Order
{
    public class OrderDao : IOrderDao
    {
        public void Add(Entity.Order order)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Order.Add(order);
                context.SaveChanges();
            }
        }

        public void Delete(Entity.Order order)
        {
            using (var context = new ApplicationDbContext())
            {
                var deleteItem = context.Order.FirstOrDefault(a => a.Id == order.Id);
                if (deleteItem == null)
                    return;
                context.Order.Remove(deleteItem);
                context.SaveChanges();
            }
        }

        public void Edit(Entity.Order order)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(order).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Entity.Order Get(int id)
        {
            Entity.Order order;
            using (var context = new ApplicationDbContext())
            {
                order = context.Order.FirstOrDefault(c => c.Id == id);
            }
            return order;
        }

        public List<Entity.Order> Load()
        {
            List<Entity.Order> order;
            using (var context = new ApplicationDbContext())
            {
                order = context.Order.ToList();
            }
            return order;
        }
    }
}