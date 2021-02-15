using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EfFramework
{
    public class EfCarDal : EfRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from cars in context.Cars
                             join brands in context.Brands
                             on cars.BrandId equals brands.Id
                             join colors in context.Colors
                             on cars.ColorId equals colors.Id
                             select new CarDetailDto { CarBrandName = brands.Name, CarName = cars.Description, ColorName = colors.Name, DailyPrice = cars.DailyPrice };
                return result.ToList();
            }
        }
    }
}
