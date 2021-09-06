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

        /// <summary>
        /// Inserts a planet at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="name"></param>
        public void InsertPlanet(int index, string name)
        {
            database.InsertPlanetAtIndex(index, name);
        }

        /// <summary>
        /// Inserts a planet at the last spot
        /// </summary>
        /// <param name="name"></param>
        public void AddPlanet(string name)
        {
            database.AddPlanet(name);
        }

        /// <summary>
        /// Completely clears the database
        /// </summary>
        public void ClearDatabase()
        {
            database.ClearDatabase();
        }

        /// <summary>
        /// Returns a list of planets that fit in the specified size range
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public List<Planet> GetPlanetsOfSize(int min, int max)
        {
            List<Planet> PlanetsList = database.GetPlanetsList();

            List<Planet> newList = PlanetsList.FindAll(planet => planet.Diameter > min && planet.Diameter < max);
            return newList;
        }

        /// <summary>
        /// Returns a list of planets whos temperature is lower than the specified one
        /// </summary>
        /// <returns></returns>
        public List<Planet> GetFreezingPlanets(int temp)
        {
            List<Planet> PlanetsList = database.GetPlanetsList();
            List<Planet> newList = PlanetsList.FindAll(planet => planet.MeanTemperature < temp);

            return newList;
        }

        /// <summary>
        /// Returns a count of the planets currently in the database
        /// </summary>
        /// <returns></returns>
        public int GetPlanetsCount()
        {
            return database.GetPlanetsCount();
        }

        /// <summary>
        /// Removes a specific planet from the database
        /// </summary>
        /// <param name="name"></param>
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

        /// <summary>
        /// Fills the beginning list
        /// </summary>
        public void FillStarterList()
        {
            database.FillStarterList();
        }

        /// <summary>
        /// Returns the list of planets in the database
        /// </summary>
        /// <returns></returns>
        public List<Planet> GetPlanetsList()
        {
            return database.GetPlanetsList();
        }
    }
}
