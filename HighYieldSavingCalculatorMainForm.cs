using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcusHighYieldSavingAccountCalculator
{
    public partial class HighYieldSavingCalculatorMainForm : Form
    {
        // Implement polymorphism by doing constructor method overloading (The previous constructor has no parameters while
        // the next one will have 1 parameter.  Since there are two constructor methods with the same name, but with different 
        // parameter lists, this would be an example of constructor method overloading.)
        //
        // Declare a constructor which has 1 parameter (splashScreenMessageString).  Inside the constructor method, 
        // use a 4-argument message box and the parameter to display a welcome message to the user.  After the message
        // box method call, call the InitializeComponent() method inside the parameterized constructor method.
        public HighYieldSavingCalculatorMainForm(string splashScreenMessageString)
        {
            MessageBox.Show(splashScreenMessageString, "Welcome!!!", MessageBoxButtons.OK);
            InitializeComponent();
            referralAmountComboBox.SelectedIndex = 0;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare variables to store initial amount, the goal amount, and the amount of referrals
            double initialAmountDouble;
            double goalAmountDouble;
            bool referralVerificationBoolean;
            int referralAmountInteger;

            // If statement to verify that the text boxes arent blank. If they are empty show the user an error message box,
            // else proceed with calculation
            if (initialAmountTextBox.Text == "" || goalAmountTextBox.Text == "")
            {
                MessageBox.Show("Please enter a valid amount in both the Initial Amount and Goal Amount textboxes!", "Calculation Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Get the values from the initialAmountTextBox and goalAmountTextBox and set the variables equal to that value
                initialAmountDouble = Convert.ToDouble(initialAmountTextBox.Text);
                goalAmountDouble = Convert.ToDouble(goalAmountTextBox.Text);

                // Create an if, else statement to verfiy that the amount in each textbox is not zero
                if (initialAmountDouble == 0 || goalAmountDouble == 0)
                {
                    MessageBox.Show("Please enter a valid amount in both the Initial Amount and Goal Amount textboxes!", "Calculation Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Create an if statement to verify that the amount put into the initial deposit is less than the goal
                    // else proceed with the calculation
                    if (initialAmountDouble > goalAmountDouble)
                    {
                        MessageBox.Show("Please make the initial amount less than the amount of the goal!", "Calculation Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // If the referralCheckBox is checked, than execute the 
                        if (referralCheckBox.Checked == true)
                        {
                            // Set referralVerificationBoolean if there are referral available
                            referralVerificationBoolean = true;

                            // Get the value from the referralAmountComboBox and set the variable referralAmountInteger equal to that
                            referralAmountInteger = Convert.ToInt32(referralAmountComboBox.Text);
                            // Instantiate an object (newReferralCalculation) of the class type ReferralHighYieldCalculator using
                            // the class's parameterized constructor
                            // This is passing the values from the initialDepositAmountDouble, goalAmountDouble, and referralAmountInteger
                            // to the ReferralHighYieldCalculator.cs class to calculate the given values with the appropiate formula
                            ReferralHighYieldSavingCalculator newReferralCalculation = new ReferralHighYieldSavingCalculator(initialAmountDouble, goalAmountDouble,
                                referralVerificationBoolean, referralAmountInteger);

                            // Show the amount of months required back to the user
                            MessageBox.Show(newReferralCalculation.ToString(), "Calculation Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reset the count of required months back to zero
                            HighYieldSavingCalculator.MonthsRequired = 0;
                        }
                        else
                        {
                            // Set referralVerificationBoolean to false since there are no referrals available
                            referralVerificationBoolean = false;

                            // Instantiate an object (newCalculation) of the class type HighYieldCalculator using the class's parameterized
                            // constructor
                            // This is passing the values from the initialDepositAmountDouble and goalAmountDouble to the
                            // HighYieldCalculator.cs class to calculate the given values with the appropiate formula
                            HighYieldSavingCalculator newCalculation = new HighYieldSavingCalculator(initialAmountDouble, goalAmountDouble, referralVerificationBoolean);

                            // Show the amount of months required back to the user
                            MessageBox.Show(newCalculation.ToString(), "Calculation Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reset the count of required months back to zero
                            HighYieldSavingCalculator.MonthsRequired = 0;
                        }
                    }
                }
            }
        }
        // Key press event for the Initial Amount Textbox to prevent any characters besides digits
        private void initialAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a valid control key
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, suppress the key press
                e.Handled = true;
            }
        }

        // Key press event for the Goal Amount Textbox to prevent any characters besides digits
        private void goalAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a valid control key
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, suppress the key press
                e.Handled = true;
            }
        }

        // Checkbox changed event for the Referral Checkbox. If it is checked then make the referral amount option visible,
        // else make sure it is invisible
        private void referralCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (referralCheckBox.Checked == true)
            {
                referralAmountLabel.Visible = true;
                referralAmountComboBox.Visible = true;
            }
            else
            {
                referralAmountLabel.Visible = false;
                referralAmountComboBox.Visible = false;
            }
        }
    }
}
