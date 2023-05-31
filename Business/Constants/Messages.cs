using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
    public class Messages
    {
        public static string MaintenanceTime = "System is under maintenance";

        public static string CarsListed = "Cars listed";
        public static string CarListedByBrandId = "Cars listed by brand id";
        public static string CarListedByColorId = "Cars listed by color id";
        public static string CarListedGetCarDetails = "Cars listed with details";
        public static string CarListedGetById = "Car listed by id";
        public static string CarAdded = "Car added";
        public static string CarDescriptionAndDailyPriceInvalid = "Car description or daily price is invalid";
        public static string CarDeleted = "Car deleted";
        public static string CarUpdated = "Car updated";

        public static string ColorsListed = "Colors listed";
        public static string ColorsListedGetById = "Color listed by id";
        public static string ColorAdded = "Color added";
        public static string ColorUpdated = "Color updated";
        public static string ColorDeleted = "Color deleted";

        public static string BrandsListed = "Brands listed";
        public static string BrandsListedGetById = "Brand listed by id";
        public static string BrandAdded = "Brand added";
        public static string BrandUpdated = "Brand updated";
        public static string BrandDeleted = "Brand deleted";

        public static string UsersListed = "Users listed";
        public static string UsersListedGetById = "User listed by id";
        public static string UserAdded = "User added";
        public static string UserUpdated = "User updated";
        public static string UserDeleted = "User deleted";

        public static string RentalsListed = "Rentals listed";
        public static string RentalsListedGetById = "Rental listed by id";
        public static string RentalAdded = "Rental added";
        public static string RentalUpdated = "Rental updated";
        public static string RentalDeleted = "Rental deleted";
        public static string RentalNotAdded = "Rental not added";

        public static string CustomersListed = "Customers listed";
        public static string CustomersListedGetByUserId = "Customer listed by user id";
        public static string CustomerAdded = "Customer added";
        public static string CustomerUpdated = "Customer updated";
        public static string CustomerDeleted = "Customer deleted";
    }
}
