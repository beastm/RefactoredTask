using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FujtajblRefactored
{
    //Class which handles the logical connections between other classes. Used for starting application.
    internal class Inititate
    {
        private  InputHandler inputHandler = new InputHandler();
        private  CalculationsHandler calculator = new CalculationsHandler();
        private  ContinuationHandler continuation = new ContinuationHandler();

        public void compose() { // final void that puts everything together
            double a = inputHandler.setInput(); // setting first input
            string op = inputHandler.setOperator(); // setting an operator
            double b = inputHandler.setInput(); // setting a second input

            if (op == "/" && b == 0){ // validation of second input
                b = calculator.nullDivisionInput(b);
            }

            Console.WriteLine("Odpoved je:");
            Console.WriteLine(calculator.calcInputs(op, a, b));
            continuation.continueCalc();
        }
    }

}
