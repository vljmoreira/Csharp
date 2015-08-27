using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrincipals.Exercicios
{
    class Qu1
    {
        static void Main() {

            string name;
            string city;
            sbyte age;
            int pinCode;

            Console.WriteLine("Please enter the information below");
            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Where are you from: ");
            city = Console.ReadLine();

            Console.WriteLine("What is your age: ");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("What is your pinCode: ");
            pinCode = Int32.Parse(Console.ReadLine());

            //Presenting the data to the user
            Console.WriteLine("please check if the information is correct: ");
            Console.WriteLine("Your name is: {0} you live in {1} and your age is {2}, your pin code is {3}", name, city, age, pinCode);
            Console.ReadLine();
            


        }
    }
}
