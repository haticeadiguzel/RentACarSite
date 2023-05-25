using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1, BrandId = 1, ColorId = 3, DailyPrice = 250, Description = "New first car",
                    ModelYear = 2001
                },
                new Car
                {
                    Id = 2, BrandId = 1, ColorId = 3, DailyPrice = 500, Description = "New second car",
                    ModelYear = 2023
                },
                new Car
                {
                    Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 150, Description = "New third car",
                    ModelYear = 2005
                },
                new Car
                {
                    Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 300, Description = "New fourth car",
                    ModelYear = 2020
                },
                new Car
                {
                    Id = 5, BrandId = 3, ColorId = 1, DailyPrice = 100, Description = "New fifth car",
                    ModelYear = 2010
                },
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        
        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
