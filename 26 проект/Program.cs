namespace _26_проект
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = b = c = 2;

            Console.WriteLine("а) 3.66;");
            double z1 = a * b + (double)c++ / (b - a * b * --c);
            Console.WriteLine(z1);

            Console.WriteLine("б) -1;");
            double z2 = (a * b + c++) / (b - a * b * --c);
            Console.WriteLine(z2);

            Console.WriteLine("в) 2;");
            double z3 = a * b + (c++ / (b - a * b)) * --c;
            Console.WriteLine(z3);

            Console.WriteLine("г) -2;");
            double z4 = (a * b + c++) - a * b * --c;
            Console.WriteLine(z4);

            Console.WriteLine("д) -4.");
            double z5 = a * ((b + c++) / b) - a * b * --c;
            Console.WriteLine(z5);
        }
    }
}
