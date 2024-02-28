namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Введите число в диапазоне 100-999");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 100 || num > 999)
            {
                Console.WriteLine("Число вне диапазона");
                return;
            }

            switch (num / 100)
            {
                case 1:
                    Console.Write("сто ");
                    break;
                case 2:
                    Console.Write("двести ");
                    break;
                case 3:
                    Console.Write("триста ");
                    break;
                case 4:
                    Console.Write("четыреста ");
                    break;
                case 5:
                    Console.Write("пятьсот ");
                    break;
                case 6:
                    Console.Write("шестьсот ");
                    break;
                case 7:
                    Console.Write("семьсот ");
                    break;
                case 8:
                    Console.Write("восемьсот ");
                    break;
                case 9:
                    Console.Write("девятьсот ");
                    break;
            }

            switch (num / 10 % 10)
            {
                case 10:
                    Console.Write("десять ");
                    break;
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
                case 4:
                    Console.Write("сорок ");
                    break;
                case 5:
                    Console.Write("пятьдесят ");
                    break;
                case 6:
                    Console.Write("шестьдесят ");
                    break;
                case 7:
                    Console.Write("семьдесят ");
                    break;
                case 8:
                    Console.Write("восемьдесят ");
                    break;
                case 9:
                    Console.Write("девяносто ");
                    break;
            }
            switch (num % 100)
            {
                case 1:
                    Console.Write("одиннадцать ");
                    break;
                case 2:
                    Console.Write("двенадцать ");
                    break;
                case 3:
                    Console.Write("тринадцать ");
                    break;
                case 4:
                    Console.Write("четырнадцать ");
                    break;
                case 5:
                    Console.Write("пятнадцать ");
                    break;
                case 6:
                    Console.Write("шестнадцать ");
                    break;
                case 7:
                    Console.Write("семнадцать ");
                    break;
                case 8:
                    Console.Write("восемнадцать ");
                    break;
                case 9:
                    Console.Write("девятнадцать ");
                    break;
            }
            switch (num % 10)
            {
                case 1:
                    Console.Write("один ");
                    break;
                case 2:
                    Console.Write("два ");
                    break;
                case 3:
                    Console.Write("три ");
                    break;
                case 4:
                    Console.Write("четыре ");
                    break;
                case 5:
                    Console.Write("пять ");
                    break;
                case 6:
                    Console.Write("шесть ");
                    break;
                case 7:
                    Console.Write("семь ");
                    break;
                case 8:
                    Console.Write("восемь ");
                    break;
                case 9:
                    Console.Write("девять ");
                    break;
            }
        }
    }
}