using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrincipals.Exercicios
{
    class evenOdd
    {
        static void Main()
        {

            int num1;
            Console.WriteLine("#######################################################");
            Console.WriteLine("to exit use '0'");
            Console.WriteLine("Insere a number to check if its EVEN or ODD");

            num1 = Convert.ToInt32(Console.ReadLine());

            while (num1 != 0)
            {

                if ((num1 % 2) == 0)
                {
                    Console.WriteLine("The number {0} is EVEN", num1);

                }
                else
                {
                    Console.WriteLine("The number {0} is ODD", num1);
                }


                Console.WriteLine("#######################################################");
                Console.WriteLine("to exit use '0'");
                Console.WriteLine("Insere a number to check if its EVEN or ODD");
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thank you for your patronage ");
            Console.ReadLine();
            }
        }
}
