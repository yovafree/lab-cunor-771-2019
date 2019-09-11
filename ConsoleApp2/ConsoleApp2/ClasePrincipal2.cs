using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ClasePrincipal2
    {
        public static void Main(String[] args) {
            int op = 1;

            do
            {
                Menu();
                op = int.Parse(Console.ReadLine());

                switch (op) {
                    case 1:
                        Console.WriteLine("Ingrese el valor: ");
                        int val = int.Parse(Console.ReadLine());
                        Console.WriteLine("El Binario es: " + DecBin(val));
                        break;
                    default:
                        break;
                }
            } while (op != 0);
        }


        public static void Menu() {
            Console.WriteLine("****************************");
            Console.WriteLine("   CONVERSOR DE DATOS");
            Console.WriteLine("1) Decimal a Binario");
            Console.WriteLine("2) Binario a Decimal");
            Console.WriteLine("0) Salir");
        }

        public static String DecBin(int dec) {
            String bin = "";

            for (int n = 0; n < 8; n++) {
                int cos = dec / 2;
                int res = dec % 2;
                dec = cos;
                bin = res + bin;
            }
            return bin;
        }
    }
}

