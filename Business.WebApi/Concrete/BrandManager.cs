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
        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            //business rules

            //mapping

            Brand brand = new();
            brand.Name = createBrandRequest.Name;
            brand.CreatedDate=DateTime.Now;

            _brandDal.Add(brand);

            //mapping

            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = createBrandRequest.Name;
            createdBrandResponse.Id = 4;
            createdBrandResponse.CreatedDate = brand.CreatedDate;

            return createdBrandResponse;
        }

        public List<GetAllBrandResponse> GetAll()
        {
            List<Brand> brands = _brandDal.GetAll();
            List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();
            foreach (Brand brand in brands)
            {
               GetAllBrandResponse allBrandResponse = new GetAllBrandResponse();
                allBrandResponse.Name = brand.Name;
                allBrandResponse.Id = brand.Id;
                allBrandResponse.CreatedDate = brand.CreatedDate;

                getAllBrandResponses.Add(allBrandResponse);
            }

            return getAllBrandResponses;
        }
    }
}
