using Business.Concrete;
using Business.Constants;
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
            //CarGetCarDetailsTest();
            //BrandGetAllTest();
            //ColorGetAllTest();
            //BrandNameTest();

            UserGetAllTest();

            RentalGetRentalDetailsTest();

            RentalAddTest();


        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental { Id = 5, CustomerId = 5, CarId = 5, RentDate = DateTime.Now, ReturnDate = null });

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalGetRentalDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();
           

            if (result.Success)
            {
                Console.WriteLine(result.Message);
                foreach (var rental in result.Data)
                {

                    Console.WriteLine(rental.Id + " " + rental.FirstName + " " + rental.LastName + " " + rental.CompanyName);
                    
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserGetAllTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.Id + "Kullanıcı Adı: " + user.FirstName + " " + "Kullanıcı Soyadı: " + user.LastName + " " + "Kullanıcı Mail: " + user.Email);
                        //"Kullanıcı Şifre: " " + " " + user.Password);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarGetCarDetailsTest()
        {


            CarManager carManager = new CarManager(new EfCarDal());


            var result = carManager.GetCarDetails();
            Console.WriteLine(result.Message);

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



        private static void ColorGetAllTest()
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

        private static void BrandGetAllTest()
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

        private static void BrandNameTest()
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
