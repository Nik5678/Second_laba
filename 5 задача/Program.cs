namespace _5_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадрат числа a:");
            Console.WriteLine(Math.Pow(a, 2));
        }
    }
}
