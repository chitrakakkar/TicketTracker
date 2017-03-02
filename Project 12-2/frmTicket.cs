using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Project_12_2
{
    public partial class frmTicket : Form
    {
        frmOptions opt = new frmOptions();   /// creating a new instance of option form.
        int count = 0;                      // defining fields globaly................
        int count1 = 0;                                 // defining fields globaly................
        public DateTime CurrentTime = DateTime.Now;
        public DateTime d = DateTime.Now.AddMinutes(1);  // defining fields globaly................
        string[] finalt = null;
        string[] ticketn = null;     // defining fields globaly................
        public frmTicket()    /// An empty constructor 
        {
            InitializeComponent();
        }
        public List<Timeslot> queue = null;      ///Defining a list which gets all the tickets added to it.
        public void Form1_Load(object sender, EventArgs e)
        {
            this.Text = string.Format(" {0:t}", DateTime.Now);  /// form text would have time now displaying
            Timer timer = new Timer();
            timer.Interval = 6000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            this.Hide();
            queue.Add(opt.Getinfo());  // adds the tickets to the list
            fillinfoListBox();    // displays the tickets in the list box.
            d = opt.ticket.starttime;   /// sets the starttime value from option form to a variable defined in this class.
           
        }
        public void fillinfoListBox()   // a user defined method to add tickets in the list box.
        {

            foreach (Timeslot t in queue)
            {
                lstTickets.Items.Add(t.Getdisplaytext("\t"));   /// adding the tickets in the list.
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = string.Format(" {0:t}", DateTime.Now);   //formatting the time

           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
// Chekcs if you want to delete the currently displayed list box*******************
        private void btnOptions_Click(object sender, EventArgs e)
        {  
            // to check when option button is selected
            string message = "All the tickets will be deleted, Do you still want to continue?";
            DialogResult button = MessageBox.Show(message, "Options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (button == DialogResult.Yes)
            {
                this.Hide();
                opt.Getinfo();
                lstTickets.Items.Clear();                
                this.Show();
//***************Refershing the data************************************
                lblOutstanding.Text = lstTickets.Items.Count.ToString();
                lblEnterTickets.ResetText();
                lblTime.Text = opt.ticket.starttime.ToShortTimeString();
                opt.ticket.ticketnumber = 0;
                count = opt.ticket.ticketnumber;
                      
            }
            else
            {
                this.Show();
            }
        }
//***************Issues the tickets on the basis of the info entered in the option form************************

        public void btnIssue_Click(object sender, EventArgs e)
        {
            
            int a = opt.ticket.guestPerMin;
            if (count1 <= a)
            {
                lstTickets.Items.Add("Ticket " + (opt.ticket.ticketnumber + count) + " : " + string.Format("{0:t}", d)); // displays the items in the listbox.
                count++;  /// counts every click
                lblOutstanding.Text = lstTickets.Items.Count.ToString(); // displays the count of tickets outstanding in the list
                lblTime.Text = string.Format("{0:t}", d);    /// displays the start time of next available slot.
                count1 += 1;
            }
            else
            {
                d = Convert.ToDateTime(lblTime.Text).AddMinutes(opt.ticket.minPerWin);
                lblTime.Text = string.Format("{0:t}", d);
                lstTickets.Items.Add("Ticket " + (opt.ticket.ticketnumber + count) + " : " + string.Format("{0:t}", d));
                count1 = 1;
                count++;
            }
        }
//******************************** When the time changes on the ticket form, it removes the items from the //
        // the list ticket box and it also splits the string inside the list to get the ticket number///
        private void frmTicket_TextChanged(object sender, EventArgs e)
        {
            List<string> value = new List<string>(); // creating new list to store the 
            List<string> ck = new List<string>();

            for (int n = lstTickets.Items.Count - 1; n >= 0; --n) // deleting the items from the list at certain position
            {
                string removelistitem = string.Format("{0:t}", DateTime.Now);
                if (lstTickets.Items[n].ToString().Contains(removelistitem))
                {
                    value.Add(lstTickets.Items[n].ToString());
                    //MessageBox.Show(lstTickets.Items[n].ToString());
                    lstTickets.Items.RemoveAt(n);
                    lblOutstanding.Text = lstTickets.Items.Count.ToString();
                }
                foreach (string line in value)   // splitting the each items twice in the list to get the ticket number
                {
                    ticketn = line.Split(':');
                    finalt = ticketn[0].Split(' ');
                    //MessageBox.Show(ticketn[0].ToString());
                    ck.Add(finalt[1]);
                    //MessageBox.Show(ck[0].ToString());
                    lblEnterTickets.Text = ck[ck.Count-1].ToString() + "-" + ck[0].ToString();
                }
            }
        }

        
    } 
}

