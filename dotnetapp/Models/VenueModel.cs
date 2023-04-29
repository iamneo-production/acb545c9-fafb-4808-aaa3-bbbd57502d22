using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class VenueModel
    {
        [Key]
        public int venueId { get; set; }
        public string? venueName { get; set; }
        public string? venueImageURL { get; set; }
        public string? venueDescription { get; set; }
        public string? VenueLocation { get; set; }
        public int Totalprice { get; set; }
        public DateTime Time { get; set; }
        public DateTime Date { get; set; }
    }
}
