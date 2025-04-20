namespace _3_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;
            decimal sum = (decimal)a + b + (decimal)c;
            Console.WriteLine("Сумма a + b + c:");
            Console.WriteLine(sum);
        }
    }
}
