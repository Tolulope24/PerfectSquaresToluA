using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tolulope Adebayo
 * Created on: 27-March-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Perfect Squares with while loop
 * This program lists the perfect squares between the numbers given by the user
*/
namespace PerfectSquaresToluA
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare Variables
            int endingValue;
            int Value;
            Double squareRootAsDouble;
            int squareRootAsInteger;
            // Set Valus to 1
            Value = 1;
            // Clear all items from the list box
            this.lstPerfectSquares.Items.Clear();
            // get the users endvalue from the user's up down box
            endingValue = Convert.ToInt32(this.nudNumbers.Value);
            // Continue stating any perfect squares between the minimum value and thge user's value
            while (Value <= endingValue)
            {
                // take the square root of the value 
                squareRootAsDouble = Math.Sqrt(Value);
                // convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);
                // the value has to be a perfect square for the integer and decimal to be equal
                if ( squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstPerfectSquares.Items.Add(Value + " is a perfect Square");
                    // this.lst.PerfectSquares.SetSelected(Number of perfect Squares
                       this.lstPerfectSquares.Refresh();
                }
                Value++;

            }
        }
    }
}
