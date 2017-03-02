﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//************ This is a class designed to check if the input done by the user is valid ***************
//**************and if not displays the error message***************
namespace Project_12_2
{
    class Validator
    {

        private static string title = "Entry Error";

        public static string Title   
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public static bool IsPresent(TextBox textbox)  // a method to check if the textboxes are empty///
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(textbox.Tag + " is a required field.", Title);
                textbox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textbox) /// if the value entered is decimal
        {
            decimal number = 0m;
            if (Decimal.TryParse(textbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show( textbox.Tag + " must be a decimal value.", Title);
                textbox.Focus();
                return false;
            }
           
        }

        
        
    }
}
