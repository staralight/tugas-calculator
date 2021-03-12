using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            Console.Write("Pilih Menu Calculator");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("\nPilih menu [1..4]: ");

            int pilihan = PilihMenu;
            if (pilihan >= 1 && pilihan <= 4)
            {
                int a;
                int b;

                Console.WriteLine();
                if (pilihan == 1)
                {
                    Console.Write("Masukkan nilai a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan nilai b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
                }

                else if (pilihan == 2)
                {
                    Console.Write("Masukkan nilai a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan nilai b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
                }
                else if (pilihan == 3)
                {
                    Console.Write("Masukkan nilai a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan nilai b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
                }
                else
                {
                    Console.Write("Masukkan nilai a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan nilai b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                }

                ExitProgram();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Maaf menu yang anda pilih salah");
                Console.ReadKey();
                return;
            }
        }
        static int PilihMenu => Convert.ToInt32(Console.ReadLine());

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
        static double Pembagian(int a, int b)
        {
            return (double)a / b;
        }

        static void ExitProgram()
        {
            Console.WriteLine("\nTekan sembarang key untuk keluar..");
            Console.ReadKey();
        }
	}
}
