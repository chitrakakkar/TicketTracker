using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//*************** This is a FromOption class that checks if the input from user is valid**********************//
//****************It checks all the text boxes and displays the error messages based on //
//************The validator class****************************
namespace Project_12_2
{
    public partial class frmOptions : Form
    {

        
        public frmOptions()
        {
            
            InitializeComponent();
            dtpStart.Value = DateTime.Now; // Assigning the default values to the Starttime datetime value.
            dtpEnd.Value = DateTime.Now.AddMinutes(5); // Adding 5 minutes extra to display the default end value. 
        }
        public Timeslot ticket = null;   /// A public ticket field with Null value.
//*************************** displays this form whenever this method is called.
        public Timeslot Getinfo()
        { 
            this.ShowDialog();
            return ticket;           
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
   //********checks if the data is valid**************************************
            if (IsValidData())
            {
   //************creates an object everytime ok button is clicked.****************
                ticket = new Timeslot(Convert.ToDateTime(dtpStart.Text), Convert.ToInt32(txtMinWin.Text), Convert.ToInt32(txtGuestWin.Text), Convert.ToDateTime(dtpEnd.Text), Convert.ToInt32(txtTicketNumber.Text));
            }

        }
        private bool IsValidData()   //*************A method to all the validator class to check the valid data******
        {
            return Validator.IsPresent(txtMinWin) &&
            Validator.IsPresent(txtGuestWin) &&
            Validator.IsPresent(txtTicketNumber) &&
            Validator.IsDecimal(txtGuestWin) &&
            Validator.IsDecimal(txtMinWin) &&
            Validator.IsDecimal(txtTicketNumber);
        }
    }
}

