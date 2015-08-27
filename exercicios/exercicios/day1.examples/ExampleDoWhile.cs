using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.day1.examples
{
    class ExampleDoWhile
    {
        static void Main() {
            int x = 10;

            do
            {
                Console.WriteLine("the value of x =" + x);
                x--;
            } while (x <= 0);
        
        }
    
    }
}
