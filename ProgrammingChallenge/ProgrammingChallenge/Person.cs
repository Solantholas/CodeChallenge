using System;
using System.Collections.Generic;

namespace DetermineGoodPets.cs
{
    class Person
    {
        public Person(string name, List<string> preferredClassification, string preferredType)
        {
            Name = name;
            PreferredClassification = preferredClassification;
            PreferredType = preferredType;
        }

        public string Name { get; set; }
        public List<string> PreferredClassification { get; set; }
        public string PreferredType { get; set; }

        public static void AddPeople(List<Person> people)
        {
            people.Add(new Person("Dalinar", new List<string> { "Mammal" }, "Snake"));
            people.Add(new Person("Kaladin", new List<string> { "Reptile", "Bird" }, "Goldfish"));
        }
    }
}
