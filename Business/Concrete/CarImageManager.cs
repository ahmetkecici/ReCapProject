using Business.Abstract;
using Core.Utitilies;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace Business.Concrete
{
    public class CarImageManager:ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage image,IFormFile imageFile)
        {

            var sourcePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img","ahmetresim.jpg");
            if (imageFile.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }
            }
            var result = ImagePath(imageFile);
            

            image.ImagePath = sourcePath;
            _carImageDal.Add(image);

            return new SuccesResult();
        }



        public IResult Delete(int id)
        {
            var image = _carImageDal.Get(p => p.Id == id);
            _carImageDal.Delete(image);
            
              
                    File.Delete(image.ImagePath);
               
               

                return new SuccesResult();
            
        }
        //public IResult Update(int id)
        //{
        //    var image = _carImageDal.Get(p => p.Id == id);
        //    var sourcePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", "ahmetresim.jpg");
        //    if (sourcePath.Length > 0)
        //    {
        //        using (var stream = new FileStream(result, FileMode.Create))
        //        {
        //            file.CopyTo(stream);
        //        }
        //    }
        //    File.Delete(sourcePath);

        //}
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }
        private static string ImagePath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.Name);
            string fileExtansion = ff.Extension;

            string path = Environment.CurrentDirectory + @"\Images\carImages";
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtansion;

            string result = $@"{path}\{newPath}";
            return result;
        }

        private IResult IsCarImageLimitExceeded(int carId)
        {

           var result= _carImageDal.GetAll(i => i.CarId == carId);
            if (result.Count>=5)
            {
                return new ErrorResult();
            }
            return new SuccesResult();
        }



    }
}