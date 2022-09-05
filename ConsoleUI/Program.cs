using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}",car.CarName,car.BrandName,car.ColorName,car.DailyPrice);
            }
        }
    }
}