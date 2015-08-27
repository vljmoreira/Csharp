using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrincipals.Exercicios
{
    class AreaRetangulo
    {
        static void Main() {
            //calcular a area de um retangulo

            double largura;
            double altura;
            double result;

            Console.WriteLine("#######################################################");
            Console.WriteLine("Calculo do retangulo A = B x h \n");
            Console.WriteLine("Qual o valor de B? ");

            largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o valor de h? ");
            altura = Convert.ToDouble(Console.ReadLine());
            result = largura * altura;

            Console.WriteLine("O Calculo do retangulo A = B x h \n");
            Console.WriteLine("O Calculo do retangulo A = {0} x {1} = {2} ", largura, altura, result);
            Console.ReadLine();
        }
    }
}
