using System.Collections.Generic;
using ServiceStation.Models.Entity;

namespace ServiceStation.Models.Service
{
    public interface IAdminService
    {
        void Add(Client client);
        void Add(Car car);
        void Edit(Client client);
        void EditCar(Car car); 
        void Delete(int id);
        void DeleteCar(int id);
        List<Client> Load();
        List<Car> LoadCar();
        Client Get(int id);
        Car GetCar(int id);
    }
}