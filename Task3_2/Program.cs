namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, l_AC, l_AB;
            Console.WriteLine("Введите A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C");
            C = Convert.ToInt32(Console.ReadLine());
            l_AC = Math.Abs(A - C);
            l_AB = Math.Abs(A - B);
            
            if(l_AC < l_AB && l_AC != 0)
                Console.WriteLine("Ближайшая точка к А - C, расстояние {0}", l_AC);
            if (l_AC > l_AB && l_AB != 0)
                Console.WriteLine("Ближайшая точка к А - B, расстояние {0}", l_AB);
            if (l_AC == l_AB && l_AC != 0)
                Console.WriteLine("Ближайшая точка к А - B,C, расстояния равны {0}", l_AB);
            if (l_AB == 0 && l_AC != 0)
                Console.WriteLine("Точка А совпадает с В");
            if (l_AC == 0 && l_AB != 0)
                Console.WriteLine("Точка А совпадает с C");
            if (l_AC == 0 && l_AB == 0)
                Console.WriteLine("Точка А совпадает с B, C");



        }
    }
}