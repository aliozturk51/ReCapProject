using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        //Tekrar  id ye göre ürünü çağırmak için revize edilecek.

        List<CarDetailDto> GetCarDetails();
    }
}
