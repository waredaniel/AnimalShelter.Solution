using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
  public class ShelterContext : DbContext
  {
    public ShelterContext(DbContextOptions<ShelterContext> options)
      : base(options)
      {
        
      }
      public DbSet<Animal> Animals { get; set; }
      
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Rex",  Age = 3, Species = "Dog", Breed = "Mix", Gender = "Male", Immunizations = true},
          new Animal { AnimalId = 2, Name = "Snowball",  Age = 4, Species = "Dog", Breed = "Maltese", Gender = "Male", Immunizations = true},
          new Animal { AnimalId = 3, Name = "Tyson",  Age = 3, Species = "Cat", Breed = "Siamese", Gender = "Male", Immunizations = false},
          new Animal { AnimalId = 4, Name = "Gilda",  Age = 7, Species = "Dog", Breed = "Pitbull", Gender = "Female", Immunizations = true},
          new Animal { AnimalId = 5, Name = "Bunny",  Age = 5, Species = "Dog", Breed = "Poodle", Gender = "Female", Immunizations = true},
          new Animal { AnimalId = 6, Name = "Groucho",  Age = 10, Species = "Cat", Breed = "Tuxedo", Gender = "Male", Immunizations = true},
          new Animal { AnimalId = 7, Name = "Peanutbutter",  Age = 1, Species = "Dog", Breed = "Lab", Gender = "Male", Immunizations = true},
          new Animal { AnimalId = 8, Name = "Swiper",  Age = 4, Species = "Cat", Breed = "Tabby", Gender = "Male", Immunizations = true},
          new Animal { AnimalId = 9, Name = "Janet",  Age = 6, Species = "Cat", Breed = "Hairless", Gender = "Female", Immunizations = true},
          new Animal { AnimalId = 10, Name = "Target",  Age = 1, Species = "Dog", Breed = "Mix", Gender = "Male", Immunizations = true},
          new Animal { AnimalId = 11, Name = "TuTu",  Age = 1, Species = "Dog", Breed = "Austrailian Shepard", Gender = "Female", Immunizations = false},
          new Animal { AnimalId = 12, Name = "Cups",  Age = 10, Species = "Cat", Breed = "Bengal", Gender = "Female", Immunizations = true}
        );
      }
  }
}