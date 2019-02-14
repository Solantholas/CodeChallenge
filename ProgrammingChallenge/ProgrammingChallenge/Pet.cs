using System;
using System.Collections.Generic;

namespace DetermineGoodPets.cs
{
    class Pet
    {

        public Pet(string name, string classification, string type, bool desired)
        {
            Name = name;
            Classification = classification;
            Type = type;
        }

        public string Name { get; set; }
        public string Classification { get; set; }
        public string Type { get; set; }
        public string Desired { get; set; }

        public static void AddPets(List<Pet> pets)
        {
            pets.Add(new Pet("Garfield", "Mammal", "Cat", true));
            pets.Add(new Pet("Odie", "Mammal", "Dog", true));
            pets.Add(new Pet("Peter Parker", "Arachnid", "Spider", true));
            pets.Add(new Pet("Kaa", "Reptile", "Snake", true));
            pets.Add(new Pet("Nemo", "Fish", "Goldfish", true));
            pets.Add(new Pet("Alpha", "Fish", "Betta", true));
            pets.Add(new Pet("Splinter", "Mammal", "Rat", true));
            pets.Add(new Pet("Coco", "Bird", "Parrot", true));
            pets.Add(new Pet("Tweety", "Bird", "Canary", true));
        }
    }
}