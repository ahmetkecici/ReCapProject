using Business.Abstract;
using Core.Utitilies;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length>2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccesResult();
            }
            else
            {
                return new ErrorResult("Araba ismi 2 den büyük olmalı");
            }
         
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccesResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id)) ;
        }

        public IDataResult<List<CarDetailDto>>GetCarDetails()
        {
            
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult< List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult< List<Car>> GetCarsByColorId(int colorId)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccesResult();
        }
    }
}
