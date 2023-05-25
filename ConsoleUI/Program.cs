using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                Id = 4,
                BrandId = 4,
                ColorId = 4,
                DailyPrice = 600,
                Description = "Audi A3",
                ModelYear = 2015
            });
            Console.ReadLine();
        }
    }
}
