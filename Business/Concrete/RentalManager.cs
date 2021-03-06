using Business.Abstract;
using Core.Utitilies;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        ICarDal _carDal;
        IRentalDal _rentDal;

        public RentalManager(IRentalDal rentDal,ICarDal carDal)
        {
            _rentDal = rentDal;
            _carDal = carDal;
        }

        public IResult Add(Rental rental)
        {
            Car car = _carDal.Get(p => p.Id == rental.CarId);
     
            if (car == null)
            {
                return new ErrorResult("Bu araba yok");

            }
            else
            {
                foreach (var item in _rentDal.GetAll().ToList())
                {
                    if (item.CarId==car.Id)
                    {
                        if (item.ReturnDate==null)
                        {
                            return new ErrorResult("Bu araba müşteride");
                        }
                    }
                }
            }
        
            _rentDal.Add(rental);
            return new SuccesResult("Ekleme başarılı");
        }

        public IResult Delete(Rental rental)
        {
            _rentDal.Delete(rental);
            return new SuccesResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentDal.Get(p=>p.Id==id));
        }

        public IResult Update(Rental rental)
        {
            _rentDal.Delete(rental);
            return new SuccesResult();
        }
    }
}
