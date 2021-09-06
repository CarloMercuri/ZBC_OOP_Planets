using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_OOP_Planets
{
    public class UI
    {
        private PlanetsControl control;

        public void MainProgram()
        {
            control = new PlanetsControl();

            Console.WriteLine("Press any key to initialize list.");
            Console.ReadKey();

            control.FillStarterList();
            Console.WriteLine("Initializing list...\n\r\n\r");


            // Printing the list to console
            PrintList(control.GetPlanetsList());

            // Inserting Venus
            AskToContinue();

            Console.WriteLine("\n\rInserting Venus between Mercury and Earth\n\r");
            control.InsertPlanet(1, "Venus");

            // Printing the list to console
            PrintList(control.GetPlanetsList());

            AskToContinue();

            Console.WriteLine("\n\rRemoving Pluto from list :( https://i.imgur.com/GyVbdMy.jpg");
            control.RemovePlanet("Pluto");

            // Printing the list to console
            PrintList(control.GetPlanetsList());

            AskToContinue();

            Console.WriteLine("\n\rInserting Pluto again, yay!");

            control.AddPlanet("Pluto");

            // Printing the list to console
            PrintList(control.GetPlanetsList());

            Console.WriteLine($"\n\rList count: {control.GetPlanetsCount()}");

            AskToContinue();

            Console.WriteLine("\n\rCreating a new list with the planets whos mean temperature is lower than 0");
           

            PrintList(control.GetFreezingPlanets(0));

            AskToContinue();

            Console.WriteLine("\n\rCreating a new list with the planets whos diameter is higher than 10,000km and lower than 50,000km");
           
            PrintList(control.GetPlanetsOfSize(10000, 50000));

            AskToContinue();

            Console.WriteLine("\n\rNow removing ALL planets from the original list");

            control.ClearDatabase();

            Console.WriteLine("\n\rCurrent list contents...\n\r");
            PrintList(control.GetPlanetsList());

            Console.WriteLine("--- End of assignment");
        }

        private void AskToContinue()
        {
            Console.WriteLine("\n\rPress any key to go on.\n\r");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the contents of a Planet list to console
        /// </summary>
        /// <param name="list"></param>
        static void PrintList(List<Planet> list)
        {
            Console.WriteLine("\n\rList contents: \n\r");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i} - {list[i].Name}");
            }
        }
    }
}
