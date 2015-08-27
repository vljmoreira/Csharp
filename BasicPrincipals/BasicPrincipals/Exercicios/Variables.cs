using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrincipals.Exercicios
{
    class Variables
    {
        static void Main() {

            int num1, num2, result;

            //Display console message
            Console.WriteLine("Please enter first value: ");
            /*
             * Convertion
             * integer = int.parse() or Convert.toInt32()
             * float = (float)
             * Double= Conver.ToDouble();
             * Decimal = Convert.ToDecimal;
             * Byte= Convert.ToByte();
             */




            //accpeting the value in num1
            num1 = Int32.Parse(Console.ReadLine());

            //Display second msg
            Console.WriteLine("Please add a second number: ");

            num2 = Int32.Parse(Console.ReadLine());

            result = num2 + num1;

            Console.WriteLine(" The sum of the two values you entered: {0} + {1} = {2} ",num1,num2,result);
            Console.ReadLine();
        
        }
    }
}
