using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {

        //Member Variables (HAS A)
        public Player player = new Player();
        
        public List<Day> Days;
        public int currentDay;
        public double buyLemons = .05;


        //Constructor
        public void RunGame()
        {
            DisplayRules();
            
            

        }

        //Member Methods (CAN DO)
        public void DisplayRules()
        {

            Console.WriteLine("Game Rules: Player goal is to make as much money as you can in 7 days by selling Lemonade" +
                " at your stand.  Buy all the items that you need from the store cups, lemons, sugar, and ice cubes. " +
                "Make your recipe and set your price based on weather conditions. At the end of the game you'll see how much money you made.");
            Console.ReadLine();
        }

        public double BuyLemons

        {


            get
            {
                return buyLemons;
            }
            set
            {
                buyLemons = value;
            }
            
            


            
            
            

        }
        


    }
}
