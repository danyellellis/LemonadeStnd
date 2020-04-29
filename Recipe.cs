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
           
        }

        //Member Methods (CAN DO)
        public void IngredientsInPitcher(Player player)
        {   // SINGLE-RESPONSIBILTY Principle
            Console.WriteLine("How many Lemons would you like to purchase?");
            amountOfLemons = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Sugar cubes would you like to purchase?");
            amountOfSugarCubes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Ice cubes would you like to purchase?");
            amountOfIceCubes = int.Parse(Console.ReadLine());
        }


    }
}
