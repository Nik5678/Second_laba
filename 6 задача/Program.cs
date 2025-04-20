namespace _6_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество знаков после запятой:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Round(c, n));
        }
    }
}
