using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_2
{
    public class Ticket
    {

        public DateTime starttime;
        public int ticketnumber;
       

  
        public Ticket()
        {
        }
        public Ticket(DateTime time, int number)
        {
            this.Starttime = time;
            this.ticketnumber = number;
            
        }
        public DateTime Starttime
        {
            get
            {
                return starttime;        
            
            }
            set
            {
                starttime = value;
    
            
            } 
        }
        public int TicketNumer
        {
            get
            {
                return ticketnumber;
            }
            set
            {
                ticketnumber = value;


            }
        }


        

        public string nextTicketNumber(string sep)
        {
            ticketnumber++;
            return ticketnumber.ToString();
        }


    }
}
