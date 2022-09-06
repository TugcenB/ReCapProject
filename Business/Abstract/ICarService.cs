using Entities.Concrete;
using Entities.DTOs;
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        Car GetById(int id);
        List<CarDetailDto> GetCarDetails();
        void Update(Car car);

    }
}
