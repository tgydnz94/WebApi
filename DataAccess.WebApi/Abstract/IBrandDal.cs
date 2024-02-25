using Entities.WebApi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.WebApi.Abstract
{
    public interface IBrandDal
    {
        void Add(Brand brand);
        List<Brand> GetAll();
    }
}
