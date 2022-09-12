using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            

        }

        private bool IfRentalBefore(Rental rental)
        {
            IRentalDal rentalDal = new EfRentalDal();
            var result = rentalDal.GetRentalDetails(r => r.ReturnDate == null && r.CarId == rental.CarId);
            if (result.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
