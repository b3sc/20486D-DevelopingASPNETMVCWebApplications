﻿using System.Collections.Generic;
using System.Linq;

namespace AnimlasMvc.Models
{
    //This class is used during development to make sure that there is data to display
    public class Data : IData
    {
        public List<Animal> AnimalsList { get; set; }

        //Initialize actors list
        public List<Animal> AnimalsInitializeData()
        {
            AnimalsList = new List<Animal>()
            {
                new Animal(){
                    Id = 1,
                    Name = "Lion",
                    Category = "Mammal",
                    UniqueInformation = "white lions exist in South Africa.",
                    ImageName = "lion.jpg"},
                new Animal(){Id = 2,
                    Name = "Horse",
                    Category = "Mammal",
                    UniqueInformation = "Acording to previous Studies horses can  understand  words.",
                    ImageName = "horse.jpg"},
                new Animal(){Id = 3,
                    Name = "Swan",
                    Category = "Bird",
                    UniqueInformation = "Swans can fly approximately 60 miles per hour.",
                    ImageName = "swan.jpg"},
                new Animal(){Id = 4,
                    Name = "Octopus",
                    Category = "Fish",
                    UniqueInformation = "Acording to previous Studies octopus learn easily by observation of another octopus.",
                    ImageName = "octopus.jpg"}
            };

            return AnimalsList;
        }

        //Get animal by id
        public Animal GetAnimalById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return AnimalsList.SingleOrDefault(a => a.Id == id);
            }
        }
    }
}
