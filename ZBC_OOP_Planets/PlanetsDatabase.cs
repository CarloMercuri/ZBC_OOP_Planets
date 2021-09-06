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
        public void AddPlanet(string name)
        {
            PlanetsList.Add(GetPlanet(name));
        }

        /// <summary>
        /// Inserts a planet at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="name"></param>
        public void InsertPlanetAtIndex(int index, string name)
        {
            PlanetsList.Insert(index, GetPlanet(name));
        }

        /// <summary>
        /// Removes a plenet from the specified index
        /// </summary>
        /// <param name="index"></param>
        public void RemovePlanetAtIndex(int index)
        {
            PlanetsList.RemoveAt(index);
        }

        /// <summary>
        /// Initialization
        /// </summary>
        public void FillStarterList()
        {
            PlanetsList.Add(GetPlanet("Mercury"));
            PlanetsList.Add(GetPlanet("Earth"));
            PlanetsList.Add(GetPlanet("Mars"));
            PlanetsList.Add(GetPlanet("Jupiter"));
            PlanetsList.Add(GetPlanet("Saturn"));
            PlanetsList.Add(GetPlanet("Uranus"));
            PlanetsList.Add(GetPlanet("Neptune"));
            PlanetsList.Add(GetPlanet("Pluto"));
        }

        /// <summary>
        /// Returns an instance of a Planet with the correct data associated
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Planet GetPlanet(string name)
        {
            switch (name)
            {
                case "Mercury":
                    return new Planet("Mercury",
                                       0.330f,
                                       4879,
                                       5427,
                                       3.7f,
                                       1407.6f,
                                       4222.6f,
                                       57.9f,
                                       88,
                                       47.4f,
                                       167,
                                       0,
                                       false);
                case "Venus":
                    return new Planet("Venus",
                                              4.87f,
                                              12104,
                                              5243,
                                              8.9f,
                                              -5832.5f,
                                              2802,
                                              108.2f,
                                              224.7f,
                                              35,
                                              464,
                                              0,
                                              false);
                case "Earth":
                    return new Planet("Earth",
                                       5.97f,
                                       12756,
                                       5514,
                                       9.8f,
                                       23.9f,
                                       24,
                                       149.6f,
                                       365.2f,
                                       29.8f,
                                       15,
                                       1,
                                       false);

                case "Mars":
                    return new Planet("Mars",
                                       0.642f,
                                       6792,
                                       3933,
                                       3.7f,
                                       24.6f,
                                       24.7f,
                                       227.9f,
                                       687,
                                       24.1f,
                                       -65,
                                       2,
                                       false);
                case "Jupiter":
                    return new Planet("Jupiter",
                                       1898,
                                       142984,
                                       1326,
                                       23.1f,
                                       9.9f,
                                       9.9f,
                                       778.6f,
                                       4331,
                                       13.1f,
                                       -110,
                                       67,
                                       true);

                case "Saturn":
                    return new Planet("Saturn",
                                       586,
                                       120536,
                                       687,
                                       9.0f,
                                       10.7f,
                                       10.7f,
                                       1433.5f,
                                       10747,
                                       9.7f,
                                       -140,
                                       62,
                                       true);

                case "Uranus":
                    return new Planet("Uranus",
                                        86.8f,
                                        51118,
                                        1271,
                                        8.7f,
                                        -17.2f,
                                        17.2f,
                                        2872.5f,
                                        30589,
                                        6.8f,
                                        -195,
                                        27,
                                        true);
                case "Neptune":
                    return new Planet("Neptune",
                                       102,
                                       49528,
                                       1638,
                                       11,
                                       16.1f,
                                       16.1f,
                                       4495.1f,
                                       60000,
                                       5.4f,
                                       -200,
                                       14,
                                       true);

                case "Pluto":
                    return new Planet("Pluto",
                                       0.0146f,
                                       2370,
                                       2095,
                                       0.7f,
                                       -153.3f,
                                       153.3f,
                                       5906.4f,
                                       90056,
                                       4.7f,
                                       -225,
                                       5,
                                       false);

                default:
                    return null;


            }
        }
    }
}
