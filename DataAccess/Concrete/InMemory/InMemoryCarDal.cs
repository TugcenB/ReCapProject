using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=150000,Description=""},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2012,DailyPrice=150000,Description=""},
                new Car{Id=3,BrandId=2,ColorId=2,ModelYear=2015,DailyPrice=300000,Description=""},
                new Car{Id=4,BrandId=3,ColorId=3,ModelYear=2018,DailyPrice=600000,Description=""}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(x => x.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(x => x.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
