using System;

namespace praktikum_junpro_modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Masukkan sebuah angka");
                int angka = int.Parse(Console.ReadLine());
                Console.WriteLine("Anda memasukkan : " + angka.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
