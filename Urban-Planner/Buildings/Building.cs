using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Planner.Buildings
{
    class Building
    {
        // Public Properties
        public  string BuildingName { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        //  should be read-only 
        public double Volume { get; private set; }

        // Private Fields
        string _designer;  // It will hold your name.
        DateTime _dateConstructed;  // This will hold the exact time the building was created.
        string _address;
        string _owner;  // This will store the name of the person who owns the building.


        // Constructor
        public void Construct()
        {
            _designer = "Martin Sisk";
            _dateConstructed = DateTime.Now;
        }

        public Building(string buildingName, string address)
        {
            BuildingName = buildingName;
            _address = address;
            Construct();
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

        // Should return width * depth * (3 * # of stories). Each story is 3 meters high.
        public void SetDeminsions()
        {
            Volume = Width * Depth * (3 * Stories);
        }

        // Print Building Fields
        public void BuildingInfo()
        {
            Console.WriteLine($"\n\nBuilding: {BuildingName}");
            Console.WriteLine($"Building address: {_address}");
            Console.WriteLine($"Designed by: {_designer}");
            Console.WriteLine($"Constructed: {_dateConstructed}");
            Console.WriteLine($"Purchase Owner: {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");

        }



    }
}
