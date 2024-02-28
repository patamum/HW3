namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3, x4 = 0, y4 = 0;
            bool res = true;

            Console.WriteLine("Введите координату X1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату X2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату X3");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y3");
            y3 = Convert.ToInt32(Console.ReadLine());

            if (x1 == x2)
            {
                if (y2 == y3)
                {
                    x4 = x3;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x3;
                    y4 = y2;
                }
                else res = false;
            }
            else if (x1 == x3)
            {
                if (y2 == y3)
                {
                    x4 = x2;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x2;
                    y4 = y2;
                }
                else res = false;
            }
            else if (x2 == x3)
            {
                if (y2 == y3)
                {
                    x4 = x1;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x2;
                    y4 = y2;
                }
                else res = false;
            }
            else res = false;

            if (res == true)
            {
                Console.WriteLine("Четвертая вершина прямоугольника x4y4 ({0},{1})", x4, y4);
            }
            else
            {
                Console.WriteLine("Не получается прямоугольник");
            }
        }
    }
}