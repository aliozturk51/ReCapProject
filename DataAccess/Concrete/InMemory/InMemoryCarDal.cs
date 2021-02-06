using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //Dependency İnjection
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{CarId=1, BrandId=1, ColorId = 240, ModelYear=2020, DailyPrice= 300, Description="Toyota Corolla" },
                new Car{CarId=2, BrandId=1, ColorId = 250, ModelYear= 2020, DailyPrice= 400, Description = "Toyota C-HR" },
                new Car{CarId=3, BrandId=2, ColorId = 150, ModelYear = 2021, DailyPrice = 700, Description = "BMW 525"},
                new Car{CarId=4, BrandId= 3, ColorId= 10, ModelYear= 2020, DailyPrice = 230, Description="Ford Focus" },
                new Car{CarId=5, BrandId=4, ColorId= 35, ModelYear= 2019, DailyPrice=500, Description= "Volkswagen Passat" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }



        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
