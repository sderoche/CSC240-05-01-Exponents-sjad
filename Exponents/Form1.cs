using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Sarah deRoche
 * Date: 10/29/2023
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance: Instructional video, textbook
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int num;

            // INPUT
            num = Convert.ToInt32(UxInputTextBox.Text);

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            UxOutputLabel.Text = "Square is: " + Square(num).ToString(); 

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            UxOutputLabel.Text += "\nCube is " + num.ToString();
           
            // OUTPUT
            // set the output to visible
            UxOutputLabel.Visible = true;

            // turn the Go button off
            UxGoButton.Enabled = false;
        }

        public int Square(int num)
        {
            // we will create this code in class
            return num * num;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return num * num * num;
        }

        private void UxResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            UxInputTextBox.Text = String.Empty;
            UxOutputLabel.Text = String.Empty;

            // turn the output to invisible
            UxOutputLabel.Visible = false;

            // turn the Go button back on
            UxGoButton.Enabled = true;
        }

    }
}
