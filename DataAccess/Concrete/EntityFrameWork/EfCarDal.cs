using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = ca.CarId,                                
                                 BrandId = br.BrandId,
                                 BrandName =br.BrandName,
                                 ColorId = co.ColorId,
                                 ColorName =co.ColorName,
                                 ModelYear = ca.ModelYear,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ImagePath = context.CarImages.Where(c => c.CarId == c.CarId).FirstOrDefault().ImagePath

                             };
                return result.ToList();
            }
        }


        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (RentCarContext context = new RentCarContext())
            {

                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             where br.BrandId == brandId
                             select new CarDetailDto
                             {
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = ca.ModelYear,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 CarId = ca.CarId,
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             where co.ColorId ==colorId
                             select new CarDetailDto
                             {

                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = ca.ModelYear,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 CarId = ca.CarId,
                                
                             };
                             return result.ToList();
            }
        }
    }
}
