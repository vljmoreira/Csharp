using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrincipals.Exercicios
{
    class calculoQuadrado
    {
        static void Main() {

            int a;
            int b;
            int result;

             Console.WriteLine("#######################################################");
            Console.WriteLine("Calculo de (a*b) ^2");
            Console.WriteLine("Qual o valor de a? ");
            
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o valor de b? ");
            b = Convert.ToInt32(Console.ReadLine());
            result = ((a*a)+(b*b)+(2*a*b));

             Console.WriteLine("O Calculo de (a*b) ^2");
            Console.WriteLine("O Calculo de  ({0}*{1}) ^2 = {2}  ", a, b, result);
            Console.ReadLine();
        }
    }
}
