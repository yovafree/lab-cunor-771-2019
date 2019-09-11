using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;
            int num3 = 8;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(" Mayor: " + num1);
                }
                else {
                    Console.WriteLine(" Mayor: " + num3);
                }
            }
            else {
                if (num2 > num3)
                {
                    Console.WriteLine(" Mayor: " + num2);
                }
                else
                {
                    Console.WriteLine(" Mayor: " + num3);
                }
            }

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(" Mayor: " + num1);
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine(" Mayor: " + num2);
            }
            else {
                Console.WriteLine(" Mayor: " + num3);
            }

            int op = 3;

            switch (op) {
                case 1:
                    Console.WriteLine("Opción 1");
                    break;
                case 2:
                    Console.WriteLine("Opción 2");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            // Ciclo For

            for (int x = 1; x <= 10; x++) {
                Console.WriteLine(" Número " + x);
            }
            double n = 0;
            do
            {
                n+=0.5;
                Console.WriteLine(" Número Do While: " + n);
            } while (n <= 10);

            n = 0;
            while (n < 10)
            {
                n++;
                Console.WriteLine(" Número While: " + n);
            }


            Console.Read();
        }
    }
}
