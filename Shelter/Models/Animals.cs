using System.ComponentModel.DataAnnotations;
namespace Shelter.Models
{
  public class Animal
  {
      public int AnimalId { get; set; }
      [Required]
      public string Name { get; set;}
      [Required]
      [Range(0, 60, ErrorMessage = "Age must be between 0 and 60.")]
      public int Age { get; set;}
      public string Species { get; set; }
      public string Breed { get; set; }
      public string Gender { get; set; }
      public bool Immunizations { get; set; }

  }
}