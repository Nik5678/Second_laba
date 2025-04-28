namespace _24_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = double.Parse(Console.ReadLine());
            double A = a;
            a = A;
            a = a * a;
            a = a * a;
            Console.WriteLine($"a) a^4 = {a}");
            
            a = A;
            double a2 = a * a;
            double a3 = a2 * a;
            a = a3 * a3;
            Console.WriteLine($"б) a^6 = {a}");
            
            a = A;
            a2 = a * a;
            double a4 = a2 * a2;
            a = a4 * a2 * a;
            Console.WriteLine($"в) a^7 = {a}");
            
            a = A;
            a = a * a;
            a = a * a;
            a = a * a;
            Console.WriteLine($"г) a^8 = {a}");
            
            a = A;
            a3 = a * a * a;
            a = a3 * a3 * a3;
            Console.WriteLine($"д) a^9 = {a}");
            
            a = A;
            a2 = a * a;
            a4 = a2 * a2;
            double a5 = a4 * a;
            a = a5 * a5;
            Console.WriteLine($"е) a^10 = {a}");
        }
    }
}
