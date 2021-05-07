using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.RazorPages.Demo.Provider
{
    public class StaticDataProvider
    {
        public Task<IEnumerable<string>> GetCitiesAsync()
        {
            var cities = new List<string> { "Mumbai", "Bengaluru", "Chennai" };

            return Task.Run(() =>
            {
                return cities.AsEnumerable();
            });
        }
    }
}
