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
            Console.WriteLine("Выбирите пункт меню \n    1)Введите A\n    2)Введите B\n    3)Операция +");
            string q = Console.ReadLine();
           
            
            switch (q)
            {
                case "1":
                        Console.WriteLine("\n\n");
                        Console.Write("Enter A: ");
                        a = int.Parse(Console.ReadLine(a));
                    goto start;
                   
                case "2":
                    Console.WriteLine("\n\n");
                    Console.Write("Enter B: ");
                    b = int.Parse(Console.ReadLine());
                    goto start;
                case "3":
                    Console.WriteLine("\n\n");
                    Console.WriteLine("A-B = {0}", a + b);
                    goto start;

            }
            
            

               /*

                int d = a - b;
                Console.WriteLine("A-B = {0}", d);

                int g = a * b;
                Console.WriteLine("A*B = {0}", g);

                int h = a / b;
                Console.WriteLine("A/B = {0}", h);
            Console.WriteLine("A/B = {0}", h);
            Console.WriteLine("A/B = {0}", h);
            Console.WriteLine("A/B = {0}", h);*/

        }
    }
}
