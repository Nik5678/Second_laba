namespace _1_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();//Создать экземпляр класса Random (генератора случайных (рандомных) чисел
            Console.WriteLine(rnd.Next()); //Вывести рандомное число от 0 до +∞
            Console.WriteLine(rnd.Next(5)); //Вывести рандомное число от 0 до maxValue
            Console.WriteLine(rnd.Next(-5, 5)); //Вывести рандомное число от minValue до maxValue

        }
    }
}
