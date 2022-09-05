using Entities.Concrete;
using Entities.DTOs;
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService:IBusinessRepository<Car>
    {
        //List<Car> GetCarsByBrandId(int brandId);
        //List<Car> GetCarsByColorId(int colorId);
        //List<CarDetailDto> GetCarDetails();
        
    }
}
