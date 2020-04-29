using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {

        //Member Variables (HAS A)
        Customer customer = new Customer();
        public Weather weather;
        public List<Customer> customers;
        
        public List<string>Days;


        //Constructor
        public Day()
        {
            weather = new Weather();
        }
        public void DayOfWeek()
        {
            Days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        }
        
        
        //Member Methods (CAN DO)



    }
}
