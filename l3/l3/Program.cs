using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    class Program
    {
        static void Main(string[] args)
        { int a = 0; int b = 0;
start:
            Console.WriteLine("Выбирите пункт меню \n    1)Введите A\n    2)Введите B\n    3)Операция +\n    4)Операция -\n    5)Операция *\n    6)Операция /\n");
            string q = Console.ReadLine();
           
            
            switch (q)
            {
                case "1":
                        Console.Write("\n");
                        Console.Write("Enter A: ");
                        a = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    goto start;
                   
                case "2":
                    Console.Write("\n");
                    Console.Write("Enter B: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    goto start;

               
                case "5":
                    Console.Write("\n");
                    Console.Write("A*B = {0}", a * b);
                    Console.WriteLine();
                    goto start;

            }
        }
    }
}
