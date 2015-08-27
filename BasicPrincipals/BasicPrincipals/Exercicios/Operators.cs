using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrincipals.Exercicios
{
    class Operators
    {
        static void Main() {
            //Program to check if the inpout character is a vowel or not

            char ch;

            Console.WriteLine("Please insert a caracter to test if is a vowel or not");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'O' || ch == 'o' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine("The letter you entered - {0} -  is a VOWEL",ch);
            } else {
                Console.WriteLine("The letter -{0} - is NOT a vowel", ch);
            }
            Console.ReadLine();

        }
    }
}
