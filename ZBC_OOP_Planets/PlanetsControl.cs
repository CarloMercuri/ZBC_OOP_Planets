using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_OOP_Planets
{
    public class PlanetsControl
    {
        private PlanetsDatabase database;

        public PlanetsControl()
        {
            database = new PlanetsDatabase();
        }

        public void InsertPlanet(int index, string name)
        {
            database.InsertPlanetAtIndex(index, name);
        }

        public void AddPlanet(string name)
        {
            database.AddPlanet(name);
        }

        public void ClearDatabase()
        {
            database.ClearDatabase();
        }

        public List<Planet> GetPlanetsOfSize(int min, int max)
        {
            List<Planet> PlanetsList = database.GetPlanetsList();

            List<Planet> newList = PlanetsList.FindAll(planet => planet.Diameter > min && planet.Diameter < max);
            return newList;
        }

        public List<Planet> GetFreezingPlanets()
        {
            List<Planet> PlanetsList = database.GetPlanetsList();
            List<Planet> newList = PlanetsList.FindAll(planet => planet.MeanTemperature < 0);

            return newList;
        }

        public int GetPlanetsCount()
        {
            return database.GetPlanetsCount();
        }

        public void RemovePlanet(string name)
        {
            List<Planet> planetsList = database.GetPlanetsList();

            // Find the index where a planet called Pluto resides
            int index = planetsList.FindIndex(planet => planet.Name == "Pluto");

            // If it's in the list, remove it
            if (index != -1)
            {
                database.RemovePlanetAtIndex(index);
            }
        }

        public void FillStarterList()
        {
            database.FillStarterList();
        }

        public List<Planet> GetPlanetsList()
        {
            return database.GetPlanetsList();
        }
    }
}
