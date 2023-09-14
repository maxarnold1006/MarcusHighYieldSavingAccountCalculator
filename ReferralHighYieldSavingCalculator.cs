using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcusHighYieldSavingAccountCalculator
{
    public class ReferralHighYieldSavingCalculator : HighYieldSavingCalculator
    {
        // Declare constants for the APY with a referral (5.3%)
        const double referralANNUALPERCENTAGEYIELDDOUBLE = 0.053;

        // Declare private member variable for the amount of referrals
        private int mReferralAmountInteger;

        // Make a constructor that derives from the constructor of the base class (HighYieldCalculator.cs)
        public ReferralHighYieldSavingCalculator(double initialAmountDouble, double goalAmountDouble, bool referralVerificationBoolean, int referralAmountInteger)
            : base(initialAmountDouble, goalAmountDouble, referralVerificationBoolean)
        {
            ReferralAmount = referralAmountInteger;
            CalculateReferralTimeRequired();
        }

        // Declare a public property (ReferralAmount) to hold the amount of referrals
        public int ReferralAmount
        {
            get
            {
                return mReferralAmountInteger;
            }
            set
            {
                mReferralAmountInteger = value;
            }
        }

        // Declare a method called CalculateTimeRequired(). This will calculate how many months it will take for the
        // initial amount to compound before the goal is reached.
        public void CalculateReferralTimeRequired()
        {
            // Local variables used to keep track of the amount of interest earned each month and how many referall months
            // are added to use the 5.3% APY
            double monthlyInterestDouble = 0;
            int referralMonthsInteger = 0;

            // Set referralMonthsAdded equal to each referral times 3
            referralMonthsInteger = ReferralAmount * 3;
            // While the initial amount is less than the goal amount, add interest to the initial amount by each month and
            // increment the amount of months 
            while (InitialAmount < GoalAmount)
            {
                // While the amount of referralMonths is less than the amount of Months required and the InitialAmount is less than the GoalAmount,
                // use the increased APY (referralANNUALPERCENTAGEYIELDDOUBLE) of 5.3%
                while (referralMonthsInteger > 0 && InitialAmount < GoalAmount)
                {
                    monthlyInterestDouble = InitialAmount * referralANNUALPERCENTAGEYIELDDOUBLE / 12;
                    InitialAmount += monthlyInterestDouble;
                    IncrementMonthsCounter();
                    // Subtract 1 from the referralMonths each time the while loop is executed
                    referralMonthsInteger--;
                }
                // After calculating for each referral month, if the goal has not been met then use the CalculateTimeRequired Method from HighYieldCalulator.cs
                if (InitialAmount < GoalAmount)
                {
                    // Once the referral months have been used up go back to using the default APY
                    CalculateTimeRequired();
                }
                // Set the calculation result message to display the amount of MonthsRequired
                CalculationResultMessage = "The amount of months needed is " + MonthsRequired;
            }
        }

        // Implement polymorphism by doing user-defined method overriding (The base class has a ToString() function.
        // Since we are overriding the base class's ToString() function with a function by the same name in this class, 
        // this would be an example of user-defined method overriding.)
        //
        // Declare a new overridden ToString() function.  Inside the function, add code to return the value in the 
        // LoginStatusMessage property. 
        public override string ToString()
        {
            return CalculationResultMessage;
        }
    }
}
