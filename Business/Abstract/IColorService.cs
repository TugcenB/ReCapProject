using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color entity);
        void Delete(Color entity);
        List<Color> GetAll();
        Color GetById(int id);
        void Update(Color entity);
       
    }
}
