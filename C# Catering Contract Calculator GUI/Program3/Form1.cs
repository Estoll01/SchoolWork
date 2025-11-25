//Ethan Tolliver
//Program 3
//CIS-199-50-4258
//Due Date: 11/7/2025
//This program calculates the total contract price for catering services based on user selections and inputs.
/*1.What is an “off by one error” in relation to arrays in C#?
    An "off by one error" occurs when a array element is outside of the valid range. For example, trying to access -1 when the minimum index is 0.
2.Why do we make arrays?
    We make arrays to store multiple values of the same type in a single variable, allowing for efficient data management.
3.What is an initializer list?
    An initializer list is a way to declare and initialize an array in a single statement, using {} to specify the elements. For example int[] numbers = {1, 2, 3, 4, 5};
4.When would we use a foreach loop?
    You use a foreach loop when you dont need to modify the elements of a collection and just want to iterate through them for reading or processing. It is used for simplicity
    and is also usually read-only.
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

namespace Program3
{
    public partial class ContractCal : Form
    {
        public ContractCal()
        {
            InitializeComponent();
        }

        private void Calbutton_Click(object sender, EventArgs e)
        {

            //Array--------------------------------------//
            //Caterer Names and Discounts
            string[] catererName = { "Shalimar", "Bombay Grill", "Clay Oven", "Little India", "India Palace" };//Caterer Names
            double[] catererDiscount = { 0.2, 0.17, 0.15, 0.10, 0.08 };//Corresponding Discounts

            //Business Names and Base Prices
            string[] businessName = { "Humana", "KFC", "LGE", "GE", "Alpine Intel" };//Business Names
            double[] businessContractPrice = { 1000, 850, 700, 650, 500 };//Corresponding Base Prices

            //Years & additional discount
            int [] contractYears = { 0, 3, 7, 11 };//Contract Years
            double[] additionalDiscount = { 50, 100, 150, 200 };//Corresponding Additional Discounts

            //Variables
            double basePrice = 0;//Business Base Price
            double catererDisc = 0;//Caterer Discount
            int minYears = 0;//Contract Years
            double additionalDisc = 0;//Additional Discount



            //Validation Checks----------------------------------//
            if (!(CatererCB.SelectedIndex >=0 ))//No selection made
            {
                MessageBox.Show("Please select a Caterer.");
                return;
            }

            //Business Validation
            if (!(BusinessCB.SelectedIndex >= 0))//No selection made
            {
                MessageBox.Show("Please select a Business.");
                return;
            }

            //Contract Years Validation
            if (!int.TryParse(ContractYearTB.Text, out minYears) || minYears < 0)//Invalid input/ less than 0
            {
                MessageBox.Show("Please enter a valid number of contract years (0 or greater).");
                return;
            }




            //Get Values from Arrays--------------------------------//
            for (int i = 0; i < catererName.Length; i++)//Get Caterer Discount
            {
                if (CatererCB.SelectedItem.ToString() == catererName[i])
                {
                    catererDisc = catererDiscount[i];
                    break;
                }
            }

            //Get Business Base Price
            for (int i = 0; i < businessName.Length; i++)//Get Business Base Price
            {
                if (BusinessCB.SelectedItem.ToString() == businessName[i])
                {
                    basePrice = businessContractPrice[i];
                    break;
                }
            }

            //Get Additional Discount
            if (minYears >= contractYears[3])//11 or more years
            {
                additionalDisc = additionalDiscount[3];
            }
            else if (minYears >= contractYears[2])//7-10 years
            {
                additionalDisc = additionalDiscount[2];
            }
            else if (minYears >= contractYears[1])//3-6 years
            {
                additionalDisc = additionalDiscount[1];
            }
            else if (minYears >= contractYears[0])//0-2 years
            {
                additionalDisc = additionalDiscount[0];
            }


            //Calculate Total Contract Price
            double totalPrice = basePrice - (basePrice * catererDisc) - additionalDisc;//Total Price Calculation
            ContractPriceTotal.Text = totalPrice.ToString("C");//Display Total Price in Currency Format




        }
    }
}
