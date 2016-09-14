using System.Collections.Generic;

namespace ServiceStation.Models.DAO.Order
{
    public interface IOrderDao
    {
        Entity.Order Get(int id);
        List<Entity.Order> Load();
        void Add(Entity.Order order);
        void Edit(Entity.Order order);
        void Delete(Entity.Order order);
    }
}