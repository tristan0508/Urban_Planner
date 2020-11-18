using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _name;
        private string _mayor;
        private DateTime _dateEstablished;
        public List<Building> buildings { get; } = new List<Building>();

        public City(string name, string mayor)
        {
            _name = name;
            _mayor = mayor;
            _dateEstablished = DateTime.Now;
            Console.WriteLine($"{_mayor} welcomes you to {_name}!");
        }

        public void addBuilding(Building building)
        {
            buildings.Add(building);
        }
    }
}