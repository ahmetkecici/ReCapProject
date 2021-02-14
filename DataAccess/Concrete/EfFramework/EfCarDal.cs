using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EfFramework
{
    public class EfCarDal : EfRepositoryBase<Car, NorthwindContext>, ICarDal
    {
       
    }
}
