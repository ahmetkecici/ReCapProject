using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EfFramework
{
    public class EfCarImageDal : EfRepositoryBase<CarImage, NorthwindContext>, ICarImageDal
    {
        
    }
}