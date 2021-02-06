using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            foreach (var car in carManager.GetCarsBrandId(2))
            {
                Console.WriteLine(car.CarId + " " +  car.ModelYear + " " + car.Description + " günlük kiralama ücreti " + car.DailyPrice + " TL");
             
            }

            foreach (var car in carManager.GetCarsByColorId(10))
            {
                Console.WriteLine(car.ModelYear);
            }
        }
    }
}
