namespace _22_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // P = a + b + c
            Console.WriteLine("Введите катет a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите катет b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Гпотенуза c:");
            Console.WriteLine(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Результат P:");
            Console.WriteLine(a + b + (Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
