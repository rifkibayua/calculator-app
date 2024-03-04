using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Calculator";

            Console.Clear();

            int option;
            int a, b, result;

            Console.WriteLine("Calculator Menu :");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian"); 

            Console.Write("\nChoose Menu : ");
            option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    Console.Write("Input Nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input Nilai b : ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    result = Penambahan(a, b);
                    Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, result);

                    break;
                case 2:
                    Console.Write("Input Nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input Nilai b : ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    result = Pengurangan(a, b);
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, result);

                    break;
                case 3:
                    Console.Write("Input Nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input Nilai b : ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    result = Perkalian(a, b);
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, result);

                    break;
                case 4:
                    Console.Write("Input Nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input Nilai b : ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    result = Pembagian(a, b);
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, result);

                    break;
                default:
                    Console.WriteLine("Menu tidak tersedia");
                    break;
            }

            Console.ReadKey();

        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
