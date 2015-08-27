using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio.Exercicios_básicos
{
    class Array
    {
        static void Main() {

            int[] a = { 12, 432, 56, 99, 88, 0, 2, 4, 43 };

            for (int i = 0; i < a.Length; i++ )
            {
                Console.WriteLine("The value of the array is a["+a[i]+"]");
            }
            Console.WriteLine("*******************************************************");
            
            foreach(int tempvar in a){
                Console.WriteLine(tempvar);
            }

        }


    }
}
