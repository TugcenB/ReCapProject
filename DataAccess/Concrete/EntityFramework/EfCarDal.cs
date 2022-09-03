using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var addedEntity= context.Entry(entity);
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                return filter == null ? context.Set<Car>().ToList():context.Set<Car>().Where(filter).ToList();
            }
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public void Update(Car entity)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
