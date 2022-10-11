using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.GetAll")]
        public IResult Add(Car car)
        {
            
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            _carDal.Update(car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        [CacheAspect] //key, value
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }
        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>( _carDal.GetById(c=>c.Id==id));
        }

        [SecuredOperation("admin")]
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            IResult result = BusinessRules.Run(CheckIfDateTime17());

            if (result != null)
            {
                return (IDataResult<List<CarDetailDto>>)result;
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
        [CacheRemoveAspect("ICarService.GetAll")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }

        private IResult CheckIfDateTime17()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            return new SuccessResult();
        }
    }
}
