using System.Collections.Generic;

namespace ServiceStation.Models.DAO.Car
{
    public interface ICarDao
    {
        Entity.Car Get(int id);
        List<Entity.Car> Load();
        void Add(Entity.Car car);
        void Edit(Entity.Car car);
        void Delete(int id);
    }
}