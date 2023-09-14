using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcusHighYieldSavingAccountCalculator
{
    public class HighYieldSavingCalculator
    {
        // Declare constant for the default APY (4.3%)
        protected const double annualPERCENTAGEYIELDDOUBLE = 0.043;

        // Declare private member variables for initial deposit amount, the goal amount, and the calculation results
        private double mInitialAmountDouble;
        private double mGoalAmountDouble;
        private string mCalculationResultMessageString;

        // Declare private member variable to verify if there is a referal or not
        private static bool mReferralVerificationBoolean;

        // Declare private member variable to count the amount of months required for growth
        static int countOfMonthsRequiredForGrowthInteger;

        // Make a constructor that requires 3 parameters, we can use this constructor to create an object from it in another class
        public HighYieldSavingCalculator(double initialAmount, double goalAmount, bool referralVerification)
        {
            // Set propertys equal to values passed through the constructor
            InitialAmount = initialAmount;
            GoalAmount = goalAmount;
            Referral = referralVerification;

            // If there is no referral, then calculate the time required
            if (Referral == false)
            {
                CalculateTimeRequired();
            }
        }

        // Declare 2 public properties (InitialAmount, GoalAmount) 
        public double InitialAmount
        {
            get
            {
                return mInitialAmountDouble;
            }
            set
            {
                mInitialAmountDouble = value;
            }
        }
        public double GoalAmount
        {
            get
            {
                return mGoalAmountDouble;
            }
            set
            {
                mGoalAmountDouble = value;
            }
        }

        // Declare another public property to confirm whether there is a referral available or not
        public static bool Referral
        {
            get
            {
                return mReferralVerificationBoolean;
            }
            set
            {
                mReferralVerificationBoolean = value;
            }
        }

        // Declare another public property (MonthsRequired) to count every month required
        public static int MonthsRequired
        {
            get
            {
                return countOfMonthsRequiredForGrowthInteger;
            }
            set
            {
                countOfMonthsRequiredForGrowthInteger = value;
            }
        }

        // Declare another property (CalculationResultMessage)
        public string CalculationResultMessage
        {
            get
            {
                return mCalculationResultMessageString;
            }
            set
            {
                mCalculationResultMessageString = value;
            }
        }

        // Declare a method called CalculateTimeRequired(). This will calculate how many months it will take for the
        // initial amount to compound before the goal is reached.
        public void CalculateTimeRequired()
        {
            // Variable used to keep track of the amount of interest earned each month
            double monthlyInterestDouble = 0;

            // While the initial amount is less than the goal amount, add interest to the initial amount by each month and
            // increment the amount of months 
            while (InitialAmount < GoalAmount)
            {
                monthlyInterestDouble = InitialAmount * annualPERCENTAGEYIELDDOUBLE / 12;
                InitialAmount += monthlyInterestDouble;
                IncrementMonthsCounter();
            }
            // Set the calculation result message to display the amount of MonthsRequired
            CalculationResultMessage = "The amount of months needed is " + MonthsRequired;
        }

        // Declare a method called IncrementMonthsCounter().  Inside the 
        // method, add code to increment the variable for counting months required by 1
        // using its property.
        public void IncrementMonthsCounter()
        {
            MonthsRequired++;
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
