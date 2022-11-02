using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int powers = 0;
            int n = 0;
            int count = 0;
            try
            {
                Console.Out.WriteLine("Введите число N"); 
                n = int.Parse(Console.ReadLine());
                if (n < 1) throw new InvalidCastException("Не удовлетворяет условию");
            }
            catch(Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }

            while (count < 10)
            {
                try
                {
                    Console.Out.WriteLine("Введите число К");
                    int k = int.Parse(Console.ReadLine());;
                    if (k < 1) throw new InvalidCastException("");

                    var power = IsPowerN(n, k);
                    Console.Out.WriteLine(power);
                    if (power)
                    {
                        powers++;
                    }

                    count++;
                }
                catch(Exception e)
                {
                    Console.Out.WriteLine(e.Message);
                }
            }

            Console.Out.WriteLine("Количество степеней числа = {0}",powers);
        }

        static bool IsPowerN(int K, int N)
        {
             var log = Math.Pow(N, 1.0/K);
             Console.Out.WriteLine(log);
             Console.Out.WriteLine(Math.Round(log));
             return Math.Abs(Math.Round(log) - log) < 0.0001;
        }
    }
}
/*Описать функцию IsPowerN(K, N) логического типа, возвращающую True,
если целый параметр K (> 0) является степенью числа N (> 1), и False в
противном случае. 

Дано число N (> 1) и набор из 10 целых положительных
чисел. С помощью функции IsPowerN найти количество степеней числа N
в данном наборе.*/