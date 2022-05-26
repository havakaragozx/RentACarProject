using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAR();
            //CUSTOMER();

        }

        private static void CUSTOMER()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetCustomerDetailDtos();
            if (result.Success)
            {
                foreach (var customer in customerManager.GetCustomerDetailDtos().Data)
                {
                    Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.Email);
                }
            }
        }

        private static void CAR()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetailDtos();
            if (result.Success)
            {
                foreach (var car in carManager.GetCarDetailDtos().Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.ColorName + "/" + car.Name);
                }

            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
