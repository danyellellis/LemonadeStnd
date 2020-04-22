using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {

        //Member Variables (HAS A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        //Constructor
        public Recipe()
        {
            amountOfLemons = 1;
            amountOfIceCubes = 4;
            amountOfSugarCubes = 2;
            pricePerCup = .25;
           // IngredientsInPitcher();
        }

        //Member Methods (CAN DO)
      //  public void IngredientsInPitcher()
       // {
       ////     Console.WriteLine("Add Ingredients to your Recipe.");
       //     int amountofLemons = int.Parse(Console.ReadLine());
      //      int amountofSugarCubes = int.Parse(Console.ReadLine());
      //      int amountofIceCubes = int.Parse(Console.ReadLine());
     //   }


    }
}
