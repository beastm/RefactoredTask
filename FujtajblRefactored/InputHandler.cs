using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FujtajblRefactored
{
    //Class to handle inputs: numbers and operators
    internal class InputHandler
    {
        public double setInput()
        { // basic function to get validated input. 
            while (true)
            {
                Console.WriteLine("Zadej cislo");

                if (double.TryParse(Console.ReadLine(), out double value))
                { // converts string to double by using bool TryParse and stores output in value
                    return value;
                }
                else
                {
                    Console.WriteLine("Nespravny vstup, zadejte prosim znovu");
                    return setInput();
                }
            }
        }

        public string setOperator()
        { //method to get validated operator by parsing input.

            string pattern = @"^[+\-/*]$"; // regex pattern that checks if it is +,*,/,-
            Regex regex = new Regex(pattern);

            while (true)
            {
                Console.WriteLine("Zadej operator");

                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                { // control of matching regex pattern
                    return input;
                }
                else
                { // in case of a bad operator, it will ask to reenter it
                    Console.WriteLine("Spatny operator, zadejte prosim znovu");
                    return setOperator();
                }

            }
        }
    }
}
