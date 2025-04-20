namespace _23_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 225;
            int b = 75;
            Console.WriteLine("Среднее арифметическое:");
            Console.WriteLine((Math.Abs(a) + Math.Abs(b)) / 2);
            Console.WriteLine("Среднее геометрическое:");
            Console.WriteLine(Math.Sqrt(Math.Abs(a) + Math.Abs(b)));
        }
    }
}
