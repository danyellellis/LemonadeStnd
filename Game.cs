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
        public Player player;
        public Store store;
        public List<Day> Days;
        public int currentDay;
        public double buyLemons = .05;


        //Constructor
        public void RunGame()
        {
            player = new Player();
            store = new Store();
            currentDay = 0;
            DisplayRules();
            GoToStore();
            BuyItems();
            

            

        
        
        }

        //Member Methods (CAN DO)
        public void DisplayRules()
        {
            Console.WriteLine("LEMONADE STAND");
            Console.WriteLine("Game Rules: Player goal is to make as much money as you can in 7 days by selling Lemonade" +
                " at your stand.  Buy all the items that you need from the store cups, lemons, sugar, and ice cubes. " +
                "Make your recipe and set your price based on weather conditions. At the end of the game you'll see how much money you made.");
            Console.ReadLine();
        }


        public void GoToStore()
        {
            Console.WriteLine("Would you like to go to the store?");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                store.SellLemons(player);
                store.SellIceCubes(player);
                store.SellCups(player);
                store.SellSugarCubes(player);
            }
            else
            {

            };
        }

        public void BuyItems()

        {
            Console.WriteLine("Please enter Buy to purchase your Items.");
            string userInput = Console.ReadLine();
            if (userInput == "Buy" )
            {
                store.pricePerLemon -= player.wallet.money;
                store.pricePerSugarCube -= player.wallet.money;
                store.pricePerIceCube -= player.wallet.money;
                store.pricePerCup -= player.wallet.money;
            }
            else
            {

            };
           

           
            
            


            
            
            

        }
        


    }
}
