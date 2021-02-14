using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
             new Car{ Id=1,BrandId=1,ColorId=1,DailyPrice=5000,Description="Uçan Arabam",ModelYear=1998},
             new Car{ Id=2,BrandId=2,ColorId=2,DailyPrice=7000,Description="Koşan Arabam",ModelYear=1998},
             new Car{ Id=3,BrandId=2,ColorId=4,DailyPrice=6000,Description="Yürüyen Arabam",ModelYear=1998},
             new Car{ Id=4,BrandId=1,ColorId=1,DailyPrice=5900,Description="kaçan Arabam",ModelYear=1998},
             new Car{ Id=5,BrandId=3,ColorId=3,DailyPrice=5500,Description="Selamlayan Arabam",ModelYear=1998}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
           
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
           
        }

        

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars; 
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new Exception("");
           //return _cars.SingleOrDefault(filter);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
        }
    }
}
