using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_conditionalOperator
{
    class Null
    {

        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("The sum of the Array elements " + (myArray?.Sum() ?? 0));
        }
    }
}
