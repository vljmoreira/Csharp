using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.day1.examples
{
    class ExampleAndOr
    {
        static void Main() {

            int x = -10;
            int y = 10;

            if(x >= 10 && y >= 0){
                Console.WriteLine("Both number are positive");
            }else if (x >= 0 || y >= 0){
                Console.WriteLine("At least one are positive");
            }else {
                Console.WriteLine("Both number are negative");
            }
        
        
        }
    }
}
