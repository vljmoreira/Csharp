using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.day1.examples
{
    class Nome
    {
        static void Main(string[] args) {

            string[] nome;
            nome = new string[5];
            nome[0]="Vera";
            nome[1]="Lucia";
            nome[2]="de";
            nome[3]="Jesus";
            nome[4]="Moreira";

            foreach(string name in nome){
            Console.WriteLine(name);
            }
           // Console.ReadLine();
        }
    }
}
