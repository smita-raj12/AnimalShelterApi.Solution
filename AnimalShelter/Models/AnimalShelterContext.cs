using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cat>()
              .HasData(
                  new Cat { CatId = 1, Name = "Maggy", Gender = "Female", Age = 8, Type = "Abyssinian Cat" },
                  new Cat { CatId = 2, Name = "Nodels", Gender = "Male", Age = 2, Type = "American Shorthair Cat" },
                  new Cat { CatId = 3, Name = "Proxima", Gender = "Female", Age = 2, Type = "Bengal Cat" },
                  new Cat { CatId = 4, Name = "Spaty", Gender = "Male", Age = 1, Type = "Burmese Cat" },
                  new Cat { CatId = 5, Name = "Milli", Gender = "Male", Age = 1, Type = "Bombay Cat" }
                );

            builder.Entity<Dog>()
              .HasData(
                new Dog { DogId = 1, Name = "Cupcake", Gender = "Female", Age = 8 , Type = "Bull dog"},
                new Dog { DogId = 2, Name = "Muffin",  Gender = "Male", Age = 10 , Type = "German Shepherd"},
                new Dog { DogId = 3, Name = "Cookie",  Gender = "Female", Age = 2 , Type = "Golden Retriever"},
                new Dog { DogId = 4, Name = "Pancake", Gender = "Female", Age = 12 , Type = "Poodle"},
                new Dog { DogId = 5, Name = "Burger", Gender = "Male", Age = 7, Type= "Boxer"}
              );

            builder.Entity<OtherAnimal>()
              .HasData(
                new OtherAnimal { OtherAnimalId = 1, Name = "Garlic",Gender = "Male", Age = 1, Type = "Lizard" },
                new OtherAnimal { OtherAnimalId = 2, Name = "Joy", Gender = "Female", Age = 3, Type = "bunny" },
                new OtherAnimal { OtherAnimalId = 3, Name = "Feaogo",Gender = "Male", Age = 1, Type = "Rat" },
                new OtherAnimal { OtherAnimalId = 4, Name = "Nancy", Gender = "Female", Age = 4, Type = "Chinchilla" },
                new OtherAnimal { OtherAnimalId = 5, Name = "Henry", Gender = "Male", Age = 1, Type = "Guinea Pig" }
              );
        }

        public DbSet<Cat> Cats { get; set; }

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<OtherAnimal> OtherAnimals { get; set; }
    }
}