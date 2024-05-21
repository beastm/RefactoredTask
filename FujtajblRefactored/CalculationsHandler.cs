using FujtajblRefactored.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FujtajblRefactored
{
    //class handling the calculation logic and logic of validating null division
    internal class CalculationsHandler
    {
        //private Inititate initiate = new Inititate();
        private InputHandler inputHandler = new InputHandler();
        public double calcInputs(string input, double a, double b)
        { //Function responsible for calculation of output

            switch (input)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
            }
            return double.NaN;
        }

        public double nullDivisionInput(double b) // validation od 2 input double, so the NullDivision exception is handled and new input could be reentered
        {
            do
            {
                Console.WriteLine("Nulou nelze delit, zadejte prosim jine cislo.");
                b = inputHandler.setInput();
            } while (b == 0); // will continue the loop if the value of b equals 0

            return b;
        }
    }
}
