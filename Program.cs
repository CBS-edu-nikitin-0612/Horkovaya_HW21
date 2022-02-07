using System;

namespace Task1
{
    delegate double MyDelegate(int x, int y, int z);
    class Program
    {
        static MyDelegate Avg = delegate (int operato1, int operato2, int operato3)
        {
            return (double)(operato1 + operato2 + operato3) / 3;
        };
        static void Main(string[] args)
        {
            double res = Avg(5, 12, 23);
            Console.WriteLine(res);
        }
    }
}