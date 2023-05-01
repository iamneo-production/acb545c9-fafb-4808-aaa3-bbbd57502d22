using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class RefereeModels
    {
        

        [Key]

        public int refereeID { get; set; }
        [Required]

        public string refereeName { get; set; }
        [Required]

        public int noOfMatches { get; set; }
    }
}
