using System;
using Urban_Planner.Buildings;

namespace Urban_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Urban Planner");

            var buildingExamp = new Building("Lower 8th Ave. Apartment", "512 8th Avenue");

            buildingExamp.Stories = 6;
            buildingExamp.Width = 18;
            buildingExamp.Depth = 24;
            buildingExamp.SetDeminsions();
            buildingExamp.Purchase("Snow White");
            buildingExamp.BuildingInfo();

            var buildingWest = new Building("New House", "1414 Creekwood Lane");

            buildingWest.Stories = 3;
            buildingWest.Width = 20;
            buildingWest.Depth = 12;
            buildingWest.SetDeminsions();
            buildingWest.Purchase("Whitney");
            buildingWest.BuildingInfo();

            City newCity = new City("Nashville", "Cooper", 1806);
            newCity.AddBuilding(buildingExamp);
            newCity.AddBuilding(buildingWest);

            newCity.CreateCity();


        }
    }
}
