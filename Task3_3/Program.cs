namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Введите возраст от 20 до 69");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 20 || age > 69)
            {
                Console.WriteLine("Возраст введен некорректно");
                return;
            }
            switch (age / 10)
            {
                case 2:
                    Console.Write("Двадцать ");
                    break;
                case 3:
                    Console.Write("Тридцать ");
                    break;
                case 4:
                    Console.Write("Сорок ");
                    break;
                case 5:
                    Console.Write("Пятьдесят ");
                    break;
                case 6:
                    Console.Write("Шестьдесят ");
                    break;

            }
            switch (age % 10)
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
            switch (age % 10)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.Write("лет");
                    break;
                case 1:
                    Console.Write("год");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.Write("года");
                    break;
            }
        }
    }
}