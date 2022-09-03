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
            carManager.Add(new Car 
            {
                Id = 1,
                BrandId=3,
                ColorId=5,
                DailyPrice=500,
                ModelYear=2015,
                Description="Hyundai"//veri ekleme hatası veriyor.
            });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}