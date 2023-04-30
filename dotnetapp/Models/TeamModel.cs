using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class TeamModel
    {
        [Key]
        public int teamId { get; set; }
        [Required(ErrorMessage = "teamName is required")]
        public string teamName { get; set; }
        public string teamDescription { get; set; }
        [Required(ErrorMessage = "noOfplayers is required")]
        public int noOfplayers { get; set; }
        [Required(ErrorMessage = "TeamLocation is required")]
        public string TeamLocation { get; set; }
        [Required]
        public string  FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }
        [Required]
        public string? Gender { get; set; }



    }
}
