using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {

        //Member Variables (HAS A)
        public string Condition;
        public int temperature;
        public List<string> weatherConditions;
        

        


        //Constructor
        public  Weather()

        {
           
            weatherConditions = new List<string>();
            temperature = 90;
            

            


           
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Partly Cloudy");
            weatherConditions.Add("Rainy");
            weatherConditions.Add("Light Wind");

            
            
            //Instantiate weatherConditions and add 3-4 condtions to it
            
        }
        public void Conditions()
        {
            Random rand = new Random();
            int index = rand.Next(4);
            Condition = weatherConditions[index];
        }
        public void Temperatures()
        {
            Random random = new Random();
            int temperature = random.Next(60, 90);
        }
       
    }

   
    

        
        
        
        
        

        
        //Create a method  that will randomly choose a string from weatherConditions list and set that to be the 'condtion' member variable
        //Create a method that will randomly choose a temperature and set that to be the 'temperature' member variable

    
    
} 
