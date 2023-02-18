﻿
using System.ComponentModel.DataAnnotations;

namespace HotelList.Core.Domain.Entities
{
    /// <summary>
    /// Domain model for Country
    /// </summary>
    public class Country
    {
        [Key]
        public Guid CountryId { get; set; }
        public string? CountryName { get; set; }
        public string? CountryCode { get; set; }
        public virtual ICollection<Hotel>? Hotels { get; set; }
    }
}
