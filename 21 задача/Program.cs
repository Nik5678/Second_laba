namespace _21_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // S = π (R^2 – r^2)
            Console.WriteLine("Введите внешний радиус R:");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите внутренний радиус r:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь кольца S:");
            Console.WriteLine((Math.Pow(R,2) - Math.Pow(r,2)) * Math.PI);
        }
    }
}
