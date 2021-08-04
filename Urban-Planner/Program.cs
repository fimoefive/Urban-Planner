using System;
using Urban_Planner.Buildings;

namespace Urban_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Urban Planner");
            var buildingExamp = new Building("512 8th Avenue");

            buildingExamp.Stories = 6;
            buildingExamp.Width = 4;
            buildingExamp.Depth = 4;
            buildingExamp.SetDeminsions();
            buildingExamp.Purchase("Snow White");
            buildingExamp.BuildingInfo();





        }
    }
}
