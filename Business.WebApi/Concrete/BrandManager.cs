using Business.WebApi.Abstract;
using Business.WebApi.Dtos.Requests;
using Business.WebApi.Dtos.Responses;
using DataAccess.WebApi.Abstract;
using Entities.WebApi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.WebApi.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal )
        {
            _brandDal=brandDal;
        }
        public CreatedBrandResponse Add(CreateBrandRequest brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
