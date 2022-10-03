using Assignment_3Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment_3Lib.Repository
{
    public interface ICitiesRepo
    {
        List<City> GetCities();
    }
}
