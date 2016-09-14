using System.Collections.Generic;
using ServiceStation.Models.DAO.Car;
using ServiceStation.Models.DAO.Client;
using ServiceStation.Models.Entity;

namespace ServiceStation.Models.Service
{
    public class AdminService : IAdminService
    {
        private readonly ICarDao _carDao;
        private readonly IClientDao _clientDao;

        public AdminService(IClientDao clientDao, ICarDao carDao)
        {
            _clientDao = clientDao;
            _carDao = carDao;
        }

        public void Add(Client client)
        {
            _clientDao.Add(client);
        }

        public void Add(Car car)
        {
            _carDao.Add(car);
        }

        public void Delete(int id)
        {
            _clientDao.Delete(id);
        }

        public void DeleteCar(int id)
        {
            _carDao.Delete(id);
        }

        public void Edit(Client client)
        {
            _clientDao.Edit(client);
        }

        public void EditCar(Car car)
        {
            _carDao.Edit(car);
        }

        public Client Get(int id)
        {
            var model = _clientDao.Get(id);
            return model;
        }
        public Car GetCar(int id)
        {
            var model = _carDao.Get(id);
            return model;
        }

        public List<Client> Load()
        {
            var client = _clientDao.Load();
            return client;
        }
        public List<Car> LoadCar()
        {
            var car = _carDao.Load();
            return car;
        }
    }
}