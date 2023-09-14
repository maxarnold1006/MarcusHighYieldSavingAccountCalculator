using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcusHighYieldSavingAccountCalculator
{
    internal static class Program
    {
        // Declare a string constant (SPLASH_SCREEN_MESSAGE_String) and set its value to 
        // "Welcome to the Breaking Bad User Login Application!".
        const string SPLASH_SCREEN_MESSAGE_String = "Welcome to the Marcus High Yield Savings Account Calculator!";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Pass the value in the string constant as an argument to the LoginMainForm's
            // constructor method in order to make it run the constructor with 1 parameter instead
            // of making it run the default constructor with 0 parameters.
            Application.Run(new HighYieldSavingCalculatorMainForm(SPLASH_SCREEN_MESSAGE_String));
        }
    }
}
