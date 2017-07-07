using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>{"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            foreach(string planet in planetList){
                Console.WriteLine(planet);
            }

            Console.WriteLine();
            List<string> otherPlanets = new List<string>(){
                "Neptune",
                "Uranus"
            };

            planetList.AddRange(otherPlanets);
            foreach(string planet in planetList){
                Console.WriteLine(planet);
            }

            Console.WriteLine();
            planetList.Insert(2, "Earth");
            planetList.Insert(3, "Venus");

            foreach(string planet in planetList){
                Console.WriteLine(planet);
            }

            Console.WriteLine();
            planetList.Add("Pluto");

            foreach(string planet in planetList){
                Console.WriteLine(planet);
            }

            Console.WriteLine();
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            foreach(string planet in rockyPlanets){
                Console.WriteLine(planet);
            }

            Console.WriteLine();
            planetList.Remove("Pluto");

            foreach(string planet in planetList){
                Console.WriteLine(planet);
            }

        }
    }
}
