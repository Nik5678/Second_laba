namespace _20_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a^2 + b^2 = c^2
            Console.WriteLine("Введите катет a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите катет b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Гпотенуза c:");
            Console.WriteLine(Math.Pow(a,2) + Math.Pow(b,2));
        }
    }
}
