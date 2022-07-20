using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2b
{
    internal class TemperatureConverter
    {
        public void ShowCelsiusToFahrenheitTable() //Shows a table of Celsius temperatures converted to Fahrenheit
        {
            const int columns = 2;

            const int max = 101;
            int p = 0;
            for (int i = 0; i < max; i += 4) //This for loop creates the table of Celsius temperatures converted to Fahrenheit
            {
                double result = CelsiusToFahrenheit(i);
                Console.Write("{0,6:f2} C = {1,6:f2} F    ", i, result);

                p++;
                if ((p % columns == 0) && (p >= columns))
                    Console.WriteLine();
            }
        }

        public void ConvertCelsiusToFahrenheit() //This method convert a temperature that the user specifies
        {
            bool bContinue = true;

            double celsius = 0;
            double result;

            while (bContinue) //This makes sure that the value entered by the user is a valid integer
            {
                Console.Write("Please enter temperature in Celsius: ");
                string strCelsius = Console.ReadLine();
                bool success = Double.TryParse(strCelsius, out celsius);

                if (success) //If the conversion from str to int succeeded, the result will be displayed
                {
                    result = CelsiusToFahrenheit(celsius);
                    Console.WriteLine(celsius + " C = " + result + " F");
                    bContinue = false;

                }
                else //If the conversion from str to int failed, a message will be displayed
                {
                    bContinue = false;
                    Console.WriteLine("Incorrect value entered.");
                }
            }
        }

        //This method converts a given Celsius value to its corresponding value in Fahrenheit, and returns the converted value to the caller
        private double CelsiusToFahrenheit(double celsius)
        {
            return 9.0 / 5.0 * celsius + 32.0; //This is the formula for converting celsius to fahrenheit
        }

        public void ShowFahrenheitToCelsiusTable() //Shows a table of Fahrenheit temperatures converted to Celsius
        {
            const int columns = 1;

            const int max = 220;
            int p = 0;
            for (int i = 0; i < max; i += 10) //This for loop creates the table of Fahrenheit temperatures converted to Celsius
            {
                double result = FahrenheitToCelsius(i);
                Console.Write("{0,6:f2} F = {1,6:f2} C    ", i, result);

                p++;
                if ((p % columns == 0) && (p >= columns))
                    Console.WriteLine();
            }
        }

        public void ConvertFahrenheitToCelsius() //This method convert a temperature that the user specifies
        {
            bool bContinue = true;

            double fahrenheit = 0;
            double result;

            while (bContinue) //This makes sure that the value entered by the user is a valid integer
            {
                Console.Write("Please enter temperature in Fahrenheit: ");
                string strFahreheit = Console.ReadLine();
                bool success = Double.TryParse(strFahreheit, out fahrenheit);

                if (success) //If the conversion from str to int succeeded, the result will be displayed
                {
                    result = FahrenheitToCelsius(fahrenheit);
                    Console.WriteLine(fahrenheit + " F = " + result + " C");
                    bContinue = false;

                }
                else //If the conversion from str to int failed, a message will be displayed
                {
                    bContinue = false;
                    Console.WriteLine("Incorrect value entered.");
                }
            }
        }


        //This method converts a given Fahrenheit value to its corresponding value in Celsius, and returns the converted value to the caller
        private double FahrenheitToCelsius(double fahrenheit)
        {
            return 5.0 / 9.0 * (fahrenheit - 32.0); //This is the formula for converting fahrenheit to celsius
        }
    }
}