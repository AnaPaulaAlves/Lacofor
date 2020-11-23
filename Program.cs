using System;

namespace laçofor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valor da sua tabuada:");
            int III = int.Parse(Console.ReadLine());

            for (int i = 0;i < 10; i ++)
            {
                Console.WriteLine($" {III} * {i} = {III*i}");
            }
        }
    }
}