using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFNgApp.Interfaces;
using EFNgApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFNgApp.Controllers
{
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        private ICity _objectCity;
        public CityController(ICity objectCity)
        {
            _objectCity = objectCity;
        }


        [HttpGet]
        [Route("GetCityList")]
        public IEnumerable<TblCities> Details()
        {
            return _objectCity.GetCities();
        }
    }
}
