using Assignment_3Lib.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WEBAPIassignment_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private ICitiesRepo cityRepo;
        public CityController(ICitiesRepo _cityRepo)
        {
            cityRepo = _cityRepo;
        }

        [HttpGet]
        public void getCity()
        {
            cityRepo.GetCities();
        }
    }
}
