using Business.WebApi.Dtos.Requests;
using Business.WebApi.Dtos.Responses;
using Entities.WebApi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.WebApi.Abstract
{
    public interface IBrandService
    {
        CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
        List<GetAllBrandResponse> GetAll();
    }
    //responses and requests
}
