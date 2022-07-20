using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2b
{
    internal class Menu
    {
        private int selectedIndex = 0;

        public void Start()
        {
            Console.Clear(); //Makes sure that the screen is clear when start method is called
            DisplayOptions(); //Show title with options
            UserSelection(); //User will use the up, down and enter keys to select option
            Continue();
        }

        private void ShowTitle() //This is the main title for the converter
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("   TEMPERATURE CONVERTER");
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
        }

        private void DisplayOptions() //This method uses a cursor (>) to show what alternative is selected
        {
            string[] options = { //These are the options:
                "Show Celsius to Fahrenheit Table",
                "Show Fahrenheit to Celcius Table",
                "Convert a specific Celsius temperature to Fahrenheit",
                "Convert a specific Fahrenheit temperature to Celsius",
                "Exit" };

            Console.WriteLine("These are your options:");
            Console.WriteLine(); //Blankspace

            for (int i = 0; i < options.Length; i++)
            {
                string currentOption = options[i];
                string prefix;

                if (i == selectedIndex) //If the current option is the selectedIndex, write an > before option.
                {
                    prefix = ">"; //A symbol for where the cursor is
                }
                else
                {
                    prefix = " "; //blank space
                }

                Console.WriteLine($"{prefix} {currentOption}"); //Displays the prefix(>cursor or blank) and the options
            }

            Console.WriteLine(); //Blankspace
            Console.WriteLine("Use UP, DOWN and ENTER to select an option!");
        }

        private void UserSelection() //This method refreshes the screen with the cursor at the selected option when a key is pressed
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                ShowTitle();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                //Updates SelectedIndex variable based on arrow keys.

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0)
                        selectedIndex = 0; //This makes sure that selectedIndex can't be less than 0 (the first option)
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex > 4)
                        selectedIndex = 4; //This makes sure that selectedIndex can't be more than 4 (the last option)
                }

            } while (keyPressed != ConsoleKey.Enter); //If the user hits enter, this method will end
        }

        private void Continue()
        {
            Console.Clear(); //Clears the screen
            ShowTitle();
            TemperatureConverter objTemperatureConverter = new(); //Create an object of the temp converter so that it can be used

            switch (selectedIndex)
            {
                case 0:
                    Console.WriteLine("-- CELSIUS TO FAHRENHEIT TABLE --");
                    Console.WriteLine(); // Blankline
                    objTemperatureConverter.ShowCelsiusToFahrenheitTable(); //Show the Celsius to Fahrenheit table
                    Console.WriteLine("Press ENTER to go back to the previous screen");
                    Console.ReadLine();
                    Start(); //Returns to the start screen
                    break;

                case 1:
                    Console.WriteLine("-- FAHRENHEIT TO CELCIUS TABLE --");
                    Console.WriteLine(); //Blankline
                    objTemperatureConverter.ShowFahrenheitToCelsiusTable(); //Show the Fahrenheit to Celcius table
                    Console.WriteLine("Press ENTER to go back to the previous screen");
                    Console.ReadLine();
                    Start(); //Returns to the start screen
                    break;

                case 2:
                    Console.WriteLine("-- CONVERT A SPECIFIC CELSIUS TEMPERATURE TO FAHRENHEIT --");
                    Console.WriteLine(); //Blankline
                    objTemperatureConverter.ConvertCelsiusToFahrenheit(); //Show the Celsius to Fahrenheit converter
                    Console.WriteLine(); //Blankline
                    Console.WriteLine("Press ESCAPE to go back");
                    Console.WriteLine("Press any other key to convert a new temperature");
                    ConsoleKey keyPressedCase2;
                    ConsoleKeyInfo keyInfoCase2 = Console.ReadKey(true); //Variable for user input
                    keyPressedCase2 = keyInfoCase2.Key;

                    if (keyPressedCase2 == ConsoleKey.Escape) //If escape is pressed go to start screen
                    {
                        Start();
                    }
                    else //If any other button is pressed clear the screen, show title and restart this case
                    {
                        Console.Clear();
                        ShowTitle();
                        goto case 2;
                    }
                    break;

                case 3:
                    Console.WriteLine("-- CONVERT A SPECIFIC FAHRENHEIT TEMPERATURE TO CELSIUS --");
                    Console.WriteLine(); //Blankline
                    objTemperatureConverter.ConvertFahrenheitToCelsius(); //Show the Fahrenheit to Celsius converter
                    Console.WriteLine(); //Blankline
                    Console.WriteLine("Press ESCAPE to go back");
                    Console.WriteLine("Press any other key to convert a new temperature");
                    ConsoleKey keyPressedCase3;
                    ConsoleKeyInfo keyInfoCase3 = Console.ReadKey(true); //Variable for user input
                    keyPressedCase3 = keyInfoCase3.Key;

                    if (keyPressedCase3 == ConsoleKey.Escape) //If escape is pressed go to start screen
                    {
                        Start();
                    }
                    else //If any other button is pressed clear the screen, show title and restart this case
                    {
                        Console.Clear();
                        ShowTitle();
                        goto case 3;
                    }
                    break;

                default:
                    Console.Clear();
                    break;
            }
        }
    }
}