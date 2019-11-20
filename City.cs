using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public DateTime Founded { get; set; }
        public List<Building> Buildings = new List<Building>();

        //methods

        public void AddBuilding(Building name)
        {
            Buildings.Add(name);
        }

        public void CityInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"The mayor is {Mayor}.");
            Console.WriteLine($"The city was founded in {Founded}.");
            Console.WriteLine($"The buildings in the city are:");
            foreach (Building building in Buildings)
            {
                building.GetInfo();
            }
        }

    }
}