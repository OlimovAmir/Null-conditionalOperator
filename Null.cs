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
            int[] myArray = {25,85,36,15 };
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("The sum of the Array elements " + (myArray?.Sum() ?? 0));
        }
    }
}
