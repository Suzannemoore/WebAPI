using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; // for For [ForeignKey]
using System.Threading.Tasks;

namespace ProjectListing.DataFile
{
    public class Hotel
    {
        // Since we have Id it is the primary key
        public int Id { get; set; }

        // Hotel name
        public string Name { get; set; }

        // Hotel rating 
        public double Rating { get; set; }

        // Hotel address
        public string Address { get; set; }

        // ForeignKey reference to the Country, strong reference for Country
        [ForeignKey(nameof(Country))]

        // hard reference 
        public int CountryId { get; set; }

        // Country object
        public Country Country { get; set; }

    }
}
