
using System.ComponentModel.DataAnnotations;
using System;

namespace dotnetapp.Models
{
    public class EventModel
    {
        [Key]
        public int EventId { get; set; }
        public string? EventName { get; set; }
        public string? ApplicantName { get; set; }
        public string? ApplicantAddress { get; set; }
        public string? ApplicantMobile { get; set; }
        public string? ApplicantEmail { get; set; }
        public string? EventAddress { get; set; }
        public DateTime EventFromDate { get; set; }
        public DateTime EventToDate { get; set; }



    }
}
