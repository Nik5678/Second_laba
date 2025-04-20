namespace _25_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1234;
            double first = num / 1000;
            double second = ((num % 1000) / 100);
            double third = (num % 100) / 10;
            double fourth = num % 10;
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine("Сумма цифр числа:");
            Console.WriteLine(first + second + third + fourth);
            Console.WriteLine("Произведение цифр числа:");
            Console.WriteLine(first * second * third * fourth);
        }
    }
}
