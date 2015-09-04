using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrincipals.Exercicios
{
    class EvenOdd
    {
        static void Main() {
            
            int num;
            Console.WriteLine("Enter your number:\t");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O numero {0} is even", num);
            }
            else {
                Console.WriteLine("O numero {0} is odd", num);
            }
            Console.ReadLine();
        
        }
    }
}
