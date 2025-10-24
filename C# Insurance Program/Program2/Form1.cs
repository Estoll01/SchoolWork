//Ethan Tolliver
//CIS-199-50-4258
//Program 2
//10/18/2025
// This program calculates the insurance premium based on user inputs.
/*1.Why do we place the radio buttons inside a group box container? 
 * to logically group related options together, it prevents the user from selecting the wrong options, it acts as a boundary to separate different radio buttons.
 * 
 *2.Is there a limit to the number of nested conditional logic statements that can be used in a program?
 * no, there is no limit to the amount nested, but doing too many can make the code hard to read and maintain.
 *
 *3.What is short circuit evaluation in regard to conditional logic?
 *short circuit is when the program uses the minimum amount of evaluations to get a result, for example for A && B if A is false it won't check B because the whole statement is already false.
 *
 *4.What kind of logic structure is an alternative to if-else statements for conditional logic? Briefly describe how this structure works.
 *switch statements are an alternative, they work by evaluating a single expression and executing the corresponding case block that matches the expression's value. it is cleaner than a long chain of else if statements.
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

namespace Program2
{
    public partial class IPCform : Form
    {
        public IPCform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Accidentlb_Click(object sender, EventArgs e)
        {

        }

        private void GroupBd1_Enter(object sender, EventArgs e)
        {

        }

        private void TotalCPYlb_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CalButton_Click(object sender, EventArgs e)
        {

            //constants
            // Health Insurance
            const double monthlyFactor = 12.0; // To covert monthly to yearly
            const double preventiveHealth = 150.0 * monthlyFactor;  // Preventive Coverage
            const double hospitalHealth = 110.0 * monthlyFactor; // Hospital Coverage
            const double prescriptionHealth = 40.0 * monthlyFactor; // Prescription Coverage
            const double noHealth = 0.0; // No Health Coverage
            // Car Insurance
            const double fullCar = 120.0 * monthlyFactor; // Full Coverage
            const double partialCar = 70.0 * monthlyFactor; // Partial Coverage
            const double noCar = 0.0; // No Car Coverage
            // Input Ranges
            const int minAge = 18; // Minimum age
            const int maxAge = 100; // Maximum age
            const int minCarValue = 1; // Minimum car value
            const int maxCarValue = 100000; // Maximum car value
            const int maxCarValueDiscount = 10500; //   Car value threshold for discount
            // Adjustment Rates and Fees
            const double carValueDiscountRate = 0.12; // 12% discount for car value under threshold
            const double accidentPenaltyRate = 0.125; // 12.5% penalty for accident history
            const double carageThreshold = 22; // Age threshold for car insurance fee
            const double carUnder22Fee = 35.0 * monthlyFactor; // Additional fee for drivers under 22
            const double smokingPenalty = 50.0 * monthlyFactor; // Smoking penalty for Preventive Health plan


            //variables
            int age; // User's age
            int carValue; // User's car value
            bool isValidAge; // Age validation flag
            bool isValidCarValue; // Car value validation flag

            // Get user inputs
            age = int.TryParse(AgeTB.Text, out age) ? age : -1;
            carValue = int.TryParse(CarTB.Text, out carValue) ? carValue : -1;

            // Validate ranges
            isValidAge = age >= minAge && age <= maxAge;
            isValidCarValue = carValue >= minCarValue && carValue <= maxCarValue;

            // Validate inputs
            if (age == -1 || carValue == -1)
            {
                MessageBox.Show("Please enter valid numeric values for age and car value.");
                return;
            }

            if (!isValidAge)
            {
                MessageBox.Show("Age must be between 18 and 100.");
                return;
            }

            if (!isValidCarValue)
            {
                MessageBox.Show("Car value must be between $1 and $100,000.");
                return;
            }



            //HEALTH INSURANCE CALCULATION

            // Calculate Health Insurance Premium
            double healthPremium = 0.0; // Initialize health premium

            // Validate Health Insurance selection
            if (HealthInsurCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Health Insurance to calculate the premium.");
                return;
            }

            // Calculate based on selected plan
            if (HealthInsurCB.SelectedItem.ToString() == "Preventive")
            {
                healthPremium = preventiveHealth;
            }
            else if (HealthInsurCB.SelectedItem.ToString() == "Hospital")
            {
                healthPremium = hospitalHealth;
            }
            else if (HealthInsurCB.SelectedItem.ToString() == "Prescription")
            {
                healthPremium = prescriptionHealth;
            }
            else if (HealthInsurCB.SelectedItem.ToString() == "None")
            {
                healthPremium = noHealth;
            }

            // Adjust for smoking status
            if (SmokeRBy.Checked && HealthInsurCB.Text == "Preventive")
            {
                healthPremium += smokingPenalty;
            }

            // Display Health Insurance Premium
            HealthCPY.Text = healthPremium.ToString("C");



            //CAR INSURANCE CALCULATION

            // Calculate Car Insurance Premium
            double carPremium = 0.0; // Initialize car premium
            double baseRate = 0.0; // Base rate for car insurance

            // Check if Car Insurance is selected
            if (CarInsurCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Car Insurance to calculate the premium.");
                return;
            }

            // Calculate based on selected plan
            if (CarInsurCB.SelectedItem.ToString() == "Full")
            {
                baseRate = fullCar;
            }
            else if (CarInsurCB.SelectedItem.ToString() == "Partial")
            {
                baseRate = partialCar;
            }
            else if (CarInsurCB.SelectedItem.ToString() == "None")
            {
                baseRate = noCar;
            }

            carPremium = baseRate; // Set initial car premium to base rate

            //age adjustment
            if (age < carageThreshold)
            {
                carPremium += carUnder22Fee;
            }

            // Adjust for car value
            if (carValue < maxCarValueDiscount)
            {
                carPremium -= carPremium * carValueDiscountRate;
            }

            //Accident history adjustment
            if (CarRBy.Checked)
            {
                double accidentPenalty = baseRate * accidentPenaltyRate;
                carPremium += accidentPenalty;
            }

            // Display Car Insurance Premium
            CarCPY.Text = carPremium.ToString("C");

            
            // Calculate Total Premium
            double totalPremium = healthPremium + carPremium;
            TotalCPY.Text = totalPremium.ToString("C");

        }
    }
}
