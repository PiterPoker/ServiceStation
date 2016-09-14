using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ServiceStation.Models.DAO.Car
{
    public class CarDao : ICarDao
    {
        public void Add(Entity.Car car)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Car.Add(car);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var item = context.Car.Find(id);
                if (item != null)
                {
                    context.Car.Remove(item);
                }

                context.SaveChanges();
            }
        }

        public void Edit(Entity.Car car)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(car).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Entity.Car Get(int id)
        {
            Entity.Car car;
            using (var context = new ApplicationDbContext())
            {
                car = context.Car.FirstOrDefault(c => c.Id == id);
            }
            return car;
        }

        public List<Entity.Car> Load()
        {
            List<Entity.Car> car;
            using (var context = new ApplicationDbContext())
            {
                car = context.Car.ToList();
            }
            return car;
        }
    }
}