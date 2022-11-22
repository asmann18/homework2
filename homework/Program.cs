namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {restart:
            int z = Convert.ToInt32(Console.ReadLine());
            bolunme(z);
            goto restart;
        }
        static void bolunme(int num1)
        {
            if (num1 % 7 == 0)
            {
                Console.WriteLine("Eded 7 ye bolunur");

            }
            else
            {
                int a = num1;
                int b = num1;
                int i = 0;
                int u = 0;
                while (a % 7 != 0)
                {
                    a++;
                    i++;
                }
                while (b % 7 != 0)
                {
                    b--;
                    u++;
                }
                if (u > i)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}