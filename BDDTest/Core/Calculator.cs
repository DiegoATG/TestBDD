using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDTest.Core
{
    public class Calculator
    {
        private List<int> numbers;

        public Calculator()
        {
            numbers = new List<int>();
        }


        public void newNumber(int number)
        {
            numbers.Add(number);
        }

        public int addNumbers()
        {
            return numbers.Sum(); 
        }

    }
}
