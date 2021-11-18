﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Age = 8,
                            Gender = "Female",
                            Name = "Maggy",
                            Type = "Abyssinian Cat"
                        },
                        new
                        {
                            CatId = 2,
                            Age = 2,
                            Gender = "Male",
                            Name = "Nodels",
                            Type = "American Shorthair Cat"
                        },
                        new
                        {
                            CatId = 3,
                            Age = 2,
                            Gender = "Female",
                            Name = "Proxima",
                            Type = "Bengal Cat"
                        },
                        new
                        {
                            CatId = 4,
                            Age = 1,
                            Gender = "Male",
                            Name = "Spaty",
                            Type = "Burmese Cat"
                        },
                        new
                        {
                            CatId = 5,
                            Age = 1,
                            Gender = "Male",
                            Name = "Milli",
                            Type = "Bombay Cat"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = 8,
                            Gender = "Female",
                            Name = "Cupcake",
                            Type = "Bull dog"
                        },
                        new
                        {
                            DogId = 2,
                            Age = 10,
                            Gender = "Male",
                            Name = "Muffin",
                            Type = "German Shepherd"
                        },
                        new
                        {
                            DogId = 3,
                            Age = 2,
                            Gender = "Female",
                            Name = "Cookie",
                            Type = "Golden Retriever"
                        },
                        new
                        {
                            DogId = 4,
                            Age = 12,
                            Gender = "Female",
                            Name = "Pancake",
                            Type = "Poodle"
                        },
                        new
                        {
                            DogId = 5,
                            Age = 7,
                            Gender = "Male",
                            Name = "Burger",
                            Type = "Boxer"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.OtherAnimal", b =>
                {
                    b.Property<int>("OtherAnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("OtherAnimalId");

                    b.ToTable("OtherAnimals");

                    b.HasData(
                        new
                        {
                            OtherAnimalId = 1,
                            Age = 1,
                            Gender = "Male",
                            Name = "Garlic",
                            Type = "Lizard"
                        },
                        new
                        {
                            OtherAnimalId = 2,
                            Age = 3,
                            Gender = "Female",
                            Name = "Joy",
                            Type = "bunny"
                        },
                        new
                        {
                            OtherAnimalId = 3,
                            Age = 1,
                            Gender = "Male",
                            Name = "Feaogo",
                            Type = "Rat"
                        },
                        new
                        {
                            OtherAnimalId = 4,
                            Age = 4,
                            Gender = "Female",
                            Name = "Nancy",
                            Type = "Chinchilla"
                        },
                        new
                        {
                            OtherAnimalId = 5,
                            Age = 1,
                            Gender = "Male",
                            Name = "Henry",
                            Type = "Guinea Pig"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}