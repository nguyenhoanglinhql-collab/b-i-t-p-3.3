using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    static bool IsPerfectNumber(int n)
    {
        if (n <= 0) return false;
        int sum = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        return sum == n;
    }
    static void PrintFibonacci(int n)
    {
        if (n <= 0) return;

        long a = 0, b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + (i == n - 1 ? "" : ", "));
            long temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Nhap N: ");
        int n = int.Parse(Console.ReadLine());
        if (IsPerfectNumber(n))
        {
            Console.WriteLine($"{n} la So hoan hao!");
        }
        else
        {
            Console.WriteLine($"{n} KHONG la So hoan hao.");
        }
        if (IsPrime(n))
        {
            Console.WriteLine($"{n} la So nguyen to.");
        }
        else
        {
            Console.WriteLine($"{n} KHONG la So nguyen to.");
        }
        Console.Write($"Day Fibonacci {n} so: ");
        PrintFibonacci(n);
    }
}
