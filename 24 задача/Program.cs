namespace _24_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("а) a4 за две операции;");
            a = a * a; 
            a = a * a;
            Console.WriteLine(a);
            Console.WriteLine("б) a6 за три операции;");
            int num = a * a;
            a = num * num * num;
            Console.WriteLine(a);
            Console.WriteLine("в) a7 за четыре операции;");
            num = a * a;
            int num2 = num * num;
            a = num2 * num2 / a;
            Console.WriteLine(a);
            Console.WriteLine("г) a8 за три операции;");
            a = a * a;
            a = a * a;
            a = a * a;
            Console.WriteLine(a);
            Console.WriteLine("д) a9 за четыре операции;");
            num = a * a * a;
            a = num * num * num;
            Console.WriteLine(a);
            Console.WriteLine("е) a10  за четыре операции.");
            num = a * a;
            num2 = num * num;
            a = num2 * num2 * num2;
            Console.WriteLine(a);
        }
    }
}
