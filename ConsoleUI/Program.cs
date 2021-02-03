﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.CarId + " " + cars.ModelYear + " " + cars.Description + " günlük kiralama ücreti " + cars.DailyPrice + " TL");
            }
          
        }
    }
}
