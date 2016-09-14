using System.Collections.Generic;
namespace ServiceStation.Models.DAO.Client
{
    public interface IClientDao
    {
        Entity.Client Get(int id);
        List<Entity.Client> Load();
        void Add(Entity.Client client);
        void Edit(Entity.Client client);
        void Delete(int id);
    }
}