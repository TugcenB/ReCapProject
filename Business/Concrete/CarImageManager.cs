using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage)//In CarImageTable, imagepath is null for now, except that everyting works.
        {
            IResult result = BusinessRules.Run(CheckCarImageCount(carImage.CarId));

            if (result!=null)
            {
                return result;
            }

            string FileName = carImage.ImagePath.FileName;
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + FileName;
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/",FileName);
            carImage.ImagePath.CopyTo(new FileStream(imagePath,FileMode.Create));
            carImage.Date=DateTime.Now;

            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.GetById(c=>c.Id == id));
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        private IResult CheckCarImageCount(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId==carId).Count;
            if (result>5)
            {
                return new ErrorResult(Messages.ACarCanNotMoreThan5Images);
            }
            return new SuccessResult();
        }
    }
}
