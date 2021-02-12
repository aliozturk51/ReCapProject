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
            EfCarTest();
            //EfBrandTest();
            //EfColorTest();
            //EfBrandNameTest();

        }


        private static void EfCarTest()
        {


            CarManager carManager = new CarManager(new EfCarDal());


            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Marka İsmi: " + car.BrandName + " " + " " + "Model: " + car.Description + " " +
                        " " + "Renk: " + car.ColorName + " " + "Model Yılı: " + car.ModelYear + " " + " " + "Günlük Fiyat: " + car.DailyPrice + " TL");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }



        private static void EfColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorId + " " + color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void EfBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandId + " " + brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void EfBrandNameTest()
        {

            //Marka ismi ekleme ve kuralların kontrolü 
            BrandManager brandManager1 = new BrandManager(new EfBrandDal());

            var result = brandManager1.Add(new Brand { BrandId = 9, BrandName = "P" });
            if (result.Success)
            {

                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);

            }
        }


    }
}
