using Assignment_3Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assignment_3Lib.Repository
{
    public class CityRepository : ICitiesRepo
    {
        private contactDBContext context;
        public CityRepository( contactDBContext _context)
        {
            context = _context;
        }
        public List<City> GetCities()
        {
            return context.Cities.ToList();
        }
    }
}
