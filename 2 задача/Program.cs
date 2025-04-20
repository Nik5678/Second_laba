using System;

namespace _2_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            string a = Console.ReadLine();
            Console.Write("Введите число b: ");
            string b = Console.ReadLine();
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(int.Parse(a), int.Parse(b)));
        }
    }
}
