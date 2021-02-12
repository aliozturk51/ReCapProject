using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IDataResult<List<Car>> GetByCarsBrandId(int brandId);
        IDataResult<List<Car>> GetByCarsColorId(int colorId);

        IDataResult<Car> GetById(int id);


        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
