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
        {
            Console.WriteLine("Выбирите пункт меню \n   1)\n    2)\n    3)");
            string q = Console.ReadLine();
            int a = 0; int b = 0;
            start:
            switch (q)
            {
                case "1":
                        Console.WriteLine("\n\n");
                        Console.Write("Enter A: ");
                        a = int.Parse(Console.ReadLine());
                    goto start;
                    break;
                case "2":
                    Console.WriteLine("\n\n");
                    Console.Write("Enter B: ");
                    b = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("\n\n");
                    Console.WriteLine("A-B = {0}", a + b);
                    break;

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
