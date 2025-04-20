namespace _18_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ax + b = 0     (a ≠ 0)
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            Console.Write(-b / a);
        }
    }
}
