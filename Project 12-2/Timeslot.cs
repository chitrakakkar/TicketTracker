using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_2
{
    public class Timeslot
    {
//**************Global variable for the class which conatins on the info on the option buton***************
        public DateTime starttime;
        public int minPerWin;
        public int guestPerMin;
        public DateTime endTime;
        public int ticketnumber;
 
        public Timeslot() { }   // An empty constructor
//*********A parametrised constructor***********************
        public Timeslot(DateTime starttime, int minPerWin, int guestPerMin, DateTime endTime, int ticketnumber)
        {
            this.Starttime = starttime;
            this.MinPerWin = minPerWin;
            this.GuestPerMin = guestPerMin;
            this.EndTime = endTime;
            this.TicketNumber = ticketnumber;
        
        }

        public DateTime Starttime   // defining property
        {
            get
            {
                return  starttime;
            }
            set
            {

                starttime = value;
            
            }
        }
        public int MinPerWin // defining property
        {
            get
            {
                return minPerWin;
            }
            set
            {

                minPerWin = value;
            
            }
       }
        public int GuestPerMin
        {
            get
            {
                return guestPerMin;
            }
            set
            {

                guestPerMin = value;
            
            }
        }
        public DateTime EndTime // defining property
        {
            get
            {
                return endTime;
            }
            set
            {

                endTime = value;

            }
        }
        public int TicketNumber   // defining property
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

        public virtual string Getdisplaytext(string sep) // displaying the combination of the string
       {

           return string.Format("{0:t}",EndTime) + string.Format("{0:t}",Starttime) + TicketNumber + GuestPerMin + MinPerWin;
       
       }

     




    }
}
