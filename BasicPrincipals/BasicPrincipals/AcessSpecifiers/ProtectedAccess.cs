using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrincipals.AcessSpecifiers
{
    class ProtectedAccess
    {
        protected string name;

        public void print()
        {
            Console.WriteLine("\n My name is " + name);
        }
    }

    class Program : ProtectedAccess //Herda da classe ProtectedAccess
    {
        static void Main(String[] args)
        {
            Program pAccess = new Program();

            Console.WriteLine("Write your name:");
            //Severity	Code	Description	Project	File	Line
            //Error CS0122  'ProtectedAccess.name' is inaccessible due to its protection level BasicPrincipals 
            pAccess.name = Console.ReadLine();
            pAccess.print();

            Console.ReadLine();
        }
    }
}