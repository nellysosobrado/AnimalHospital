using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AnimalHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {

             List<Animal> Animals = new List<Animal>
            {
                new Animal { Name = "Catname1", Species = "Ragdoll", Age = 2,vaccinated = true, TotalLegs= 4},
                new Animal { Name = "Catname2", Species = "Ragdoll", Age = 2,vaccinated = true, TotalLegs= 4},
                new Animal { Name = "Catname3", Species = "Ragdoll", Age = 2,vaccinated = true, TotalLegs= 4},
                new Animal { Name = "Catname4", Species = "Ragdoll", Age = 2,vaccinated = true, TotalLegs= 4},
                new Animal { Name = "Catname5", Species = "Ragdoll", Age = 2,vaccinated = true, TotalLegs= 4},
                new Animal { Name = "Catname6", Species = "GoldenRetriever", Age = 8,vaccinated = true, TotalLegs= 4},
                new Animal { Name = "DogName1", Species = "GoldenRetriever", Age = 8,vaccinated = true, TotalLegs= 4},
                new Animal { Name = "DogName2", Species = "GoldenRetriever", Age = 8,vaccinated = true, TotalLegs= 4},
                new Animal { Name = "DogName3", Species = "GoldenRetriever", Age = 8,vaccinated = true, TotalLegs= 4},
                new Animal { Name = "BirdName2", Species = "piegon", Age = 1,vaccinated = false, TotalLegs= 2},
                new Animal { Name = "Shadow", Species = "piegon", Age = 2,vaccinated = false, TotalLegs= 2},
            };

            //a. (int) How many dogs?
            TotalDogs(Animals);


            //b. (Animal )Which animal is the oldest?
            OldestAnimal(Animals);


            //c.  (List) Display vaccinated animals
            CheckVaccinatedAnimals(Animals);

            //d (List) Animals with 4 legs and over 3 years old
            CheckAnimalsWithMorethan4Legs(Animals);

            //e. (bool) Check if there's a animal with name 'Shadow'
            CheckSpecificAnimal(Animals);

            Console.ReadLine();
        }
        public static void TotalDogs(List<Animal> Animals)
        {
            int totalDogs = Animals.Count(x => x.Species == "GoldenRetriever");
            Console.WriteLine("Total dogs: " + totalDogs);

            Console.WriteLine(new string('-', 80));
        }
        public static void OldestAnimal (List<Animal> Animals)
        {
            Animal oldestAnimal = Animals.OrderByDescending(x => x.Age).FirstOrDefault();
            Console.WriteLine($"Oldest Animal: {oldestAnimal.Name} \tAge:{oldestAnimal.Age}\tSpecies: {oldestAnimal.Species} ");
            Console.WriteLine(new string('-', 80));
        }
        public static void CheckVaccinatedAnimals(List<Animal> Animals)
        {
            List<Animal> vaccinatedAnimals = Animals.Where(x => x.vaccinated == true).ToList();
            foreach (var animalC in vaccinatedAnimals)
            {
                Console.WriteLine($"Name: {animalC.Name} \tvaccinated?:{animalC.vaccinated} \tSpecies:{animalC.Species}");
            }
            Console.WriteLine(new string('-', 80));
        }
        public static void CheckAnimalsWithMorethan4Legs(List<Animal> Animals)
        {
             List<Animal> animalsWithMoreThan4Legs = Animals.Where(x => x.TotalLegs > 4 || x.Age > 3).ToList();
            foreach (var animalD in animalsWithMoreThan4Legs) {

                Console.WriteLine($"Name:{animalD.Name} \tTotal legs: {animalD.TotalLegs}");
            }
            Console.WriteLine(new string('-', 80));

        }
        public static void CheckSpecificAnimal(List<Animal> Animals)
        {

            string search = "Shadow";
            Console.WriteLine("Does a animal with name " + search + " exists?");

            for(int i = 0; i<10; i++) 
            {
                Console.Write("\rChecking   "); 
                Thread.Sleep(100); 
                Console.Write("\rChecking.  "); 
                Thread.Sleep(100); 
                Console.Write("\rChecking.. "); 
                Thread.Sleep(100); 
                Console.Write("\rChecking..."); 
                Thread.Sleep(100); 
            }
            bool Animal = Animals.Any(x => x.Name == search);
            Console.WriteLine();
            Console.WriteLine(Animal);
           
        }

    }
}
