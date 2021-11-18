using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Range(0, 20, ErrorMessage = "Age must be between 0 and 20.")]
        public int Age { get; set; }
        [Required]
        public string Type { get; set; }
    }
}