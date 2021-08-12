using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectListing.DataFile
{
    public class Country
    {
        // Here are the fields for our Country table

        // Since we have Id it is the primary key
        public int Id { get; set; }

        // Country name
        public string Name { get; set; }
        
        // Country Continent
        public string Continent { get; set; }

        // Country code
        public string Code { get; set; }


    }
}
