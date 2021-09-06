using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_OOP_Planets
{
    public class PlanetsDatabase
    {
        private List<Planet> PlanetsList;

        public PlanetsDatabase()
        {
            PlanetsList = new List<Planet>();
        }

        /// <summary>
        /// Returns the list of planets
        /// </summary>
        /// <returns></returns>
        public List<Planet> GetPlanetsList()
        {
            return PlanetsList;
        }

        /// <summary>
        /// Completely clears the database
        /// </summary>
        public void ClearDatabase()
        {
            PlanetsList.Clear();
        }

        /// <summary>
        /// Returns the count of items in the planets database
        /// </summary>
        /// <returns></returns>
        public int GetPlanetsCount()
        {
            return PlanetsList.Count;
        }

        /// <summary>
        /// Adds a specific planet at the end of the list
        /// </summary>
        /// <param name="name"></param>
        public void AddPlanet(Planet planet)
        {
            PlanetsList.Add(planet);
        }

        /// <summary>
        /// Inserts a planet at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="name"></param>
        public void InsertPlanetAtIndex(int index, Planet planet)
        {
            PlanetsList.Insert(index, planet);
        }

        /// <summary>
        /// Removes a plenet from the specified index
        /// </summary>
        /// <param name="index"></param>
        public void RemovePlanetAtIndex(int index)
        {
            PlanetsList.RemoveAt(index);
        }
       
    }
}
