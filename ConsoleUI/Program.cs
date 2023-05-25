using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();
            CarDetailsTest();

            Console.ReadLine();
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine(carDetail.CarName + " / " + carDetail.BrandName + " / " + carDetail.ColorName + " / " + carDetail.DailyPrice);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {
                Id = 8,
                BrandId = 5,
                ColorId = 2,
                DailyPrice = 350,
                Description = "BMW",
                ModelYear = 2019
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------------------");

            carManager.Delete(new Car
            {
                Id = 8,
                BrandId = 5,
                ColorId = 2,
                DailyPrice = 350,
                Description = "BMW",
                ModelYear = 2019
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------------------");

            carManager.Update(new Car
            {
                Id = 7,
                BrandId = 5,
                ColorId = 2,
                DailyPrice = 350,
                Description = "Range Rover",
                ModelYear = 2019
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------------------");

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------------------");

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(carManager.GetById(2).Description);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand
            {
                Id = 1,
                Name = "Mercedes",
            });

            brandManager.Add(new Brand
            {
                Id = 2,
                Name = "Audi",
            });

            brandManager.Add(new Brand
            {
                Id = 3,
                Name = "BMW",
            });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            brandManager.Delete(new Brand
            {
                Id = 3,
                Name = "BMW",
                
            });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            brandManager.Update(new Brand
            {
                Id = 2,
                Name = "Porche",
            });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(brandManager.GetById(1).Name);

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color
            {
                Id = 1,
                Name = "Red",
            });

            colorManager.Add(new Color
            {
                Id = 2,
                Name = "Blue",
            });

            colorManager.Add(new Color
            {
                Id = 3,
                Name = "Green",
            });

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            colorManager.Delete(new Color
            {
                Id = 3,
                Name = "Green",

            });

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            colorManager.Update(new Color
            {
                Id = 2,
                Name = "Black",
            });

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(colorManager.GetById(1).Name);

        }
    }
}
