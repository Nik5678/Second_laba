namespace _19_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ax^2 - bx + c = e
            Console.WriteLine("Введите a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите e:");
            double e = Convert.ToDouble(Console.ReadLine());

            double ce = c - e;

            double discriminant = (Math.Pow(b, 2) - 4 * a * ce);

            if (discriminant < 0)
            {
                Console.WriteLine("Нет действительных корней");
            }
            else
            {
                double sqrtD = Math.Sqrt(discriminant);
                double x1 = (b + sqrtD) / (2 * a);
                double x2 = (b - sqrtD) / (2 * a);

                if (discriminant == 0)
                {
                    Console.WriteLine("x = {0}", x1);
                }
                else
                {
                    Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
                }

            }
        } 
    }
}
