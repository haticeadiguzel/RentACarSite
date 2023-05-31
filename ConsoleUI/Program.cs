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
            //CarDetailsTest();
            //RentalTest();
            //UserTest();
            CustomerTest();

            Console.ReadLine();
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDetail in carManager.GetCarDetails().Data)
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

            foreach (var car in carManager.GetAll().Data)
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

            foreach (var car in carManager.GetAll().Data)
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

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------------------");

            foreach (var car in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------------------");

            foreach (var car in carManager.GetCarsByColorId(2).Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(carManager.GetById(2).Data.Description);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand
            {
                Id = 4,
                Name = "Şahin",
            });

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            brandManager.Delete(new Brand
            {
                Id = 4,
                Name = "Şahin",
                
            });

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            brandManager.Update(new Brand
            {
                Id = 2,
                Name = "Porche",
            });

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(brandManager.GetById(1).Data.Name);

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

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            colorManager.Delete(new Color
            {
                Id = 3,
                Name = "Green",

            });

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            colorManager.Update(new Color
            {
                Id = 2,
                Name = "Black",
            });

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(colorManager.GetById(1).Data.Name);

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = new DateTime(2021, 02, 15),
                ReturnDate = new DateTime(2021, 02, 20)
            });

            rentalManager.Add(new Rental
            {
                CarId = 2,
                CustomerId = 2,
                RentDate = new DateTime(2021, 02, 15)
            });

            rentalManager.Add(new Rental
            {
                CarId = 3,
                CustomerId = 3,
                RentDate = new DateTime(2023, 02, 15),
                ReturnDate = new DateTime(2023, 02, 20)
            });

            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.CarId);
            }

            Console.WriteLine("--------------------------------------------------");

        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Add(new User
            {
                Id = 1,
                FirstName = "Mehmet",
                LastName = "Kaya",
                Email = "mehmet@",
                Password = "123456"
            });

            userManager.Add(new User
            {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Kaya",
                Email = "ahmet@",
                Password = "123456"
            });

            userManager.Add(new User
            {
                Id = 3,
                FirstName = "Ali",
                LastName = "Kaya",
                Email = "ali@",
                Password = "123456"
            });

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }

            Console.WriteLine("--------------------------------------------------");

            userManager.Delete(new User
            {
                Id = 3,
                FirstName = "Ali",
                LastName = "Kaya",
                Email = "ali@",
                Password = "123456"

            });

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }

            Console.WriteLine("--------------------------------------------------");

            userManager.Update(new User
            {
                Id = 2,
                FirstName = "Umut",
                LastName = "Kaya",
                Email = "umut@",
                Password = "123456"
            });

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(userManager.GetById(1).Data.FirstName);

        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Add(new Customer
            {
                Id = 1,
                CompanyName = "Aselsan"
            });

            customerManager.Add(new Customer
            {
                Id = 2,
                CompanyName = "Baykar"
            });

            customerManager.Add(new Customer
            {
                Id = 3,
                CompanyName = "Havelsan"
            });

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }

            Console.WriteLine("--------------------------------------------------");

            customerManager.Delete(new Customer
            {
                Id = 3,
                CompanyName = "Havelsan"
            });

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }

            Console.WriteLine("--------------------------------------------------");

            customerManager.Update(new Customer
            {
                Id = 2,
                CompanyName = "Roketsan"
            });

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(customerManager.GetById(1).Data.CompanyName);

        }
    }
}
