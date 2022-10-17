//6. Функцию, определяющую является ли число простым, 
//то есть возвращающую true, если число простое, иначе - false

using System;
 
class Program
{
    static void Main()
    {
        Console.Write("Введите число = ");
        int n = int.Parse(Console.ReadLine());
 
        bool isPrime;
        do
        {
            isPrime = true;
            double sqrt = Math.Sqrt(n);
            for (int i = 2; i <= sqrt; i++)
                if (n % i == 0)
                    isPrime = false;
            if (!isPrime)
                n++;
        }
        while (!isPrime);
 
        Console.WriteLine("Простое " + n);
    }
}
