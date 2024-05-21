using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FujtajblRefactored
{
    internal class ContinuationHandler
    {
        private Inititate initiate;

        public void SetInitiate(Inititate _initiate) { 
            initiate = _initiate;
        }
        public void continueCalc()
        { // void responsible for proceeding in calculations
            Console.WriteLine("pokud chcete pokracovat ve vypoctech, zmacknete Enter");
            while (true)
            {
                var keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                { // checks if Enter is pressed
                    initiate.compose();
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                { // checks if Escape is pressed
                    break;
                }
                else
                    break;
            }
        }
    }
}
