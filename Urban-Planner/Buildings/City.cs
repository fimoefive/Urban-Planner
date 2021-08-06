using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Planner.Buildings
{
    class City
    {

        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Year { get; set; }

        private List<Building> Buildings = new List<Building>();

        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }




    }
}
