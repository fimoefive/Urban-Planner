using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Planner.Buildings
{
    class City
    {
        // Properties
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Year { get; set; }
        // List of Buildings
        private List<Building> Buildings = new List<Building>();

        // Method
        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }

        // Method
        public void CreateCity()
        {
            Console.WriteLine($"\n\nThe new buildings constructed in the city of {Name}.");
            foreach (Building building in Buildings)
            {
                Console.WriteLine($"\n\nBuilding: {building.BuildingName}");
                Console.WriteLine($"Space: {building.Volume}");
            }
        }

        // Constructor Method
        public City(string name, string mayor, int year)
        {
            Name = name;
            Mayor = mayor;
            Year = year;
        }



    }
}
