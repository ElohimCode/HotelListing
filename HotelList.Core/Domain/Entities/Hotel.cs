using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Reflection;

namespace HotelList.Core.Domain.Entities
{
    /// <summary>
    /// Domain model for Hotel
    /// </summary>
    public class Hotel
    {
        public Guid HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? HotelAddress { get; set; }
        public double Rating { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country? Country { get; set; }

        public override string ToString()
        {
            return $"Hotell ID: {HotelId}, Hotel Name: {HotelName}, Hotel Address: {HotelAddress}, Country ID: {Country?.CountryId}, Country: {Country?.CountryName}, Country Code: {Country?.CountryCode}";
        }
    }
}
