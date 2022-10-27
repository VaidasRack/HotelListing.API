using Microsoft.Build.Framework;

namespace HotelListing.API.Models.Country
{
    public class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
