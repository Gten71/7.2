using System;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var res = Console.ReadLine();
            var length = res.Length;
            var a = "";
            for (int i = length; i >= 1; i--)
            {
                a += res[i - 1];
            }
            Console.WriteLine(a);
        }
    }
}
