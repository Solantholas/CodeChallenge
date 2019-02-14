/* Write a console application to determine if a given pet would be good for each person.  
 * How you structure the objects is up to you, but the preferred classification/type 
 * objects on a person should match the classification/type properties of a pet.    */

using System;
using System.Collections.Generic;
using System.Linq;

namespace DetermineGoodPets.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list of all people
            List<Person> people = new List<Person>();
            Person.AddPeople(people);

            //create list of all pets
            List<Pet> pets = new List<Pet>();
            Pet.AddPets(pets);

            //combine lists and sets true/false message for pets
            var allCombinations = from person in people
                                  from pet in pets
                                  let isPreferred = person.PreferredClassification.Contains(pet.Classification)
                                  || person.PreferredType == pet.Type
                                  let message = isPreferred ? "good" : "bad"
                                  let petMessage = $"{pet.Name} would be a {message} pet."
                                  select new { person, pet, petMessage };

            //print based on requirements
            PrintList(people, allCombinations);
        }

        private static void PrintList(List<Person> people, dynamic allCombinations)
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"Pets for {person.Name}:\n");

                foreach (var pet in allCombinations)
                {
                    if (person.Name == pet.person.Name)
                        Console.WriteLine($"{pet.petMessage}");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
