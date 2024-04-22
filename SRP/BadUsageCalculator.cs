using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{

    public class BadUsageCalculator
    {
        public bool ValidateInput(int number)
        {
            // Check if number is positive
            return number >= 0;
        }

        public int Square(int number)
        {
            // Calculate square of a number
            return number * number;
        }
    }
}
