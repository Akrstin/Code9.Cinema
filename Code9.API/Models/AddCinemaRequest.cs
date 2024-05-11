using System.ComponentModel.DataAnnotations;

namespace Code9.API.Models
{
    public class AddCinemaRequest
    {
        [Required]
        [MinLength(3)]

        public string City { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumberOfAuditoriums { get; set; }
        [Required]
        public string Street { get; set; }

    }
}
