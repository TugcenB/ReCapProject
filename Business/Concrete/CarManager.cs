using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("It is not possible");
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(c=>c.Id==id);
        }

        //public List<CarDetailDto> GetCarDetails()
        //{
        //    return _carDal.GetCarDetails();
        //}

        //public List<Car> GetCarsByBrandId(int brandId)
        //{
        //    return _carDal.GetAll().Where(c => c.BrandId == brandId).ToList(); 
        //}

        //public List<Car> GetCarsByColorId(int colorId)
        //{
        //    return _carDal.GetAll().Where(c=>c.ColorId == colorId).ToList();
        //}

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        
    }
}
