# MarcusHighYieldSavingAccountCalculator
Application Purpose: The purpose of the application is to calculate how many months it would take to reach the users set goal based on the initial amount, 
the APY, whether or not they have any referrals, and the amount of referrals they have. The APY will be set to 4.3% by default, but for every referral 
the user has it is increased to 5.3% for a total of 3 months per referral.

Business Requirements:
The application will require variables to calculate how long it will take to reach your goal.

Input Variables: How much is the initial balance (double), any referrals (boolean), how many referrals(integer), and what the end goal (double).

Processing Variables: the APY (two constants, one for referrals and one for without), the total amount of interest(double), and how many months it will take to reach that goal(integer)

Plan:
A class tied to the form, that will validate the inputs are appropriate, and determine if the user has referrals or not

We will create a class that uses encapsulation to calculate the amount of time required to reach the goal with the base 4.3% APY.

We will use a while loop to determine how many months it will take. It should keep looping for each month until the initial amount is no longer less than the final goal amount.

A child class that inherits the properties and methods from the first class and also utilizes encapsulation to calculate the amount of time required to reach the goal at 5.3% APY 
for however many months are earned from the amount of referrals. Once the total amount of referral months run out, the APY should revert back to 4.3% APY.

We will use a while loop to determine how many months it will take. It should keep looping for each month until the initial amount is no longer less than the final goal amount or if the total amount of referral months has been depleted. Once the total amount of referral months has depleted and the goal still hasn’t been reached then it should refer back to calculation declared in the parent class.

Design: 
For the design of this application we will use labels to explain to the user how the app works. We’ll also use textboxes for the user to input their initial amount and the 
amount they’d like to meet for their goal. A checkbox for whether they have referrals or not, and a combo box to choose how many they have. A button will be used to 
execute the code once the values have been entered.

So in conclusion for this app we will need...

Two Textboxes to input the initial amount and goal amount

One Checkbox to check for any referrals

One combobox to choose how many referrals

One button to execute the calculation

Implementation:
The application will have three classes to be coded. The HighYieldCalculatorForm.cs, the HighYieldCalculator.cs, and the ReferralHighYieldCalculator.cs

(HighYieldSavingCalculatorMainForm.cs)
This class will have code to verify that the values entered into the text boxes are valid, and code to verify if the user has referrals or not.

The initial amount cannot be more than the goal amount

The textboxes cannot be left blank or have a value of 0

The textboxes should only allow numerical values to be entered

The combo box should only allow referrals of 1-5

The combo box and it’s label should only be visible if the checkbox is checked

The calculate button, once pressed, should validate all of the requirements above, and perform the calculation by passing the values of the Initial Amount and the Goal Amount 
to the appropriate class

The class should instantiate an object from the HighYieldCalculator.cs class to perform the calculation by passing the values of the Initial Amount and the Goal Amount 
to that class if there are no referrals, if there are referrals available, then the class will also have an object instantiated from the ReferralHighYieldCalculator.cs 
to perform the calculation.

(HighYieldSavingCalculator.cs)
This class will have code to set the values passed from the HighYieldCalculatorForm.cs to properties in order to encapsulate it.

The constructor will take the values and set them to the appropriate variables it will also call upon a method made to calculate the amount of months required based off of the inputs

Use a while loop to make the method that will keep adding the created interest to the Initial Amount at 4.3% APY, and incrementing the amount of months required after each loop

(ReferralHighYieldSavingCalculator.cs)
This class will have code to set the values passed from the HighYieldCalculatorForm.cs to properties in order to encapsulate it.

The constructor will take the values and set them to the appropriate variables it will also call upon a method made to calculate the amount of months required based off of the inputs.

Use a while loop to make the method that will keep adding the created interest to the Initial Amount at 5.3%, incrementing the amount of months required after each loop, 
and subtracting from the total amount of referral months each loop. After the total amount of referral months has depleted, revert back to the method declared in 
HighYieldCalculator.cs to continue the calculation at 4.3% instead of 5.3%.

Testing:
We will test the functionality of this app by making sure all requirements can be met.

Attempt to enter a blank value, 0, or a character value into the textboxes.

Attempt to make the initial value greater than the goals value into the textboxes.

Verify the results by doing the calculation with a calculator to ensure they’re correct.

Verify that the calculation is being done at 5.3% APY for the total amount of referral months, and then reverts back to 4.3% APY once the referral months are depleted
and the goal still hasn’t been met.



