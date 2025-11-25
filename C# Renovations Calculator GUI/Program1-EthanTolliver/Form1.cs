//Ethan Tolliver
//Program 1
//CIS 199-50-4258
//Due: 9/25/2025
//This program will calculate the client name, location, and total cost using the information provided by the user.
//Questions:
/* 1. I could change the variable to bool for the discount and use a checkbox instead of a text box. If I use this the statement would be if (Discount) instead of if (Discount == 1).
 * 2. = means assignment and == means comparison. = Stores the value on the right into the variable on the left. == compares two values and returns true if they are equal and false if they are not.
 * 3. char is used to store a single character like 'A' string is used to store a sequence of characters like "Hello World". 
 * 4. We avoid magic numbers because they make the code harder to read and maintain. Using named constants makes the code more readable and easier to update.
 * It Also helps to avoid errors that can occur when the same magic number is used in multiple places and needs to be changed.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1_EthanTolliver
{
    public partial class QuoteCal : Form
    {
        public QuoteCal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Program1_Load(object sender, EventArgs e)
        {

        }

        //event handler for the calculate button
        private void CalButton_Click(object sender, EventArgs e)
        {

            //variables
            string clientName; //client name
            string location; //location
            double hours; //hours worked
            int squareFeet; //square feet
            int staff; //number of staff
            int Discount; //discount percentage //*****Not Sure if needed as variable or constant

            //constants
            const double BASE_FEE = 500.00; //base fee
            const double LABOR_RATE = 20.00; //labor rate per hour
            const double SQFT_RATE = 10.00; //rate per square foot
            const double FIRSTTIME_DISCOUNT = 0.10; //first time client discount percentage

            //get user input
            clientName = CliNameTb.Text; //get client name from text box
            location = LocationTb.Text; //get location from text box
            squareFeet = int.Parse(NOSTb.Text); //get number of square feet from text box
            hours = double.Parse(HWTb.Text); //get hours worked from text box
            staff = int.Parse(StaffTb.Text); //get number of staff from text box
            Discount = int.Parse(FirstTimeTb.Text); //get discount percentage from text box

            //calculate total cost
            double totalCost = BASE_FEE + (LABOR_RATE * hours) + (SQFT_RATE * squareFeet);
      
            if (Discount == 1) //if first time client
            {
                totalCost = totalCost - (totalCost * FIRSTTIME_DISCOUNT); //apply discount
            }

            //display output
            NameFin.Text = clientName; //display client name
            LocationFin.Text = location; //display location
            TotalCostFin.Text = totalCost.ToString("c"); //display total cost formatted as currency




        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void NameFin_Click(object sender, EventArgs e)
        {

        }
    }
}
