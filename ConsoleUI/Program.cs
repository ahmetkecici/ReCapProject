using Business.Concrete;
using DataAccess.Concrete.EfFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             CarTest();
            //ColorTest();
          //  BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            // brandManager.Add(new Brand { Name="Mercedes"});
            // brandManager.Update(new Brand {Id=1, Name = "bmv" });
            brandManager.Delete(new Brand { Id = 2 });
            //Brand brand = brandManager.GetById(1);
            //Console.WriteLine(brand.Id);
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            // colorManager.Add(new Color { Name="blue"});
            // colorManager.Update(new Color {Id=1, Name = "Green" });
            // colorManager.Delete(new Color { Id = 2, Name = "blue" });
            Color color = colorManager.GetById(1);
            Console.WriteLine(color.Id);
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { BrandId = 1, ColorId = 4, DailyPrice = 14, Description = "reno", });




            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.CarBrandName+""+ item.ColorName+item.DailyPrice+item.CarName);
            }
        }
    }
}
