using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tests
{
    class Program
    {
        static void Main()
        {
            Predicate<int> isOne = x => x == 1;

            Predicate<int> isGreaterEqualFive = x => x >= 5;


            Console.WriteLine(isOne.Invoke(1));
            Console.WriteLine(isOne.Invoke(2));
            Console.WriteLine(isGreaterEqualFive.Invoke(4));
            Console.WriteLine(isGreaterEqualFive.Invoke(5));
        }
    }
}
