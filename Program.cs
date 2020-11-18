using System;
using Planner;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City RichCity = new City("Richmond", "Bob");
            BuildCity(RichCity);
            RichCity.buildings.ForEach(building => building.DisplayBuildingInfo());
        }
        static void BuildCity(City city)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue")
        {
            Stories = 100,
            Width = 60.5,
            Depth = 50.5
        };
        FiveOneTwoEight.Designer("Design, LLC");
        FiveOneTwoEight.Construct();
        FiveOneTwoEight.Purchase("Bobby");
        city.addBuilding(FiveOneTwoEight);
        }
        
    }
}
