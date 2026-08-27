using System;

class Program
{
    // 1. Ham kiem tra so nguyen to
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // 2. Ham kiem tra so hoan hao
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

    // 3. Ham in N so Fibonacci dau tien
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
        // Nhap so nguyen duong N
        Console.Write("Nhap N: ");
        int n = int.Parse(Console.ReadLine());

        // Kiem tra So hoan hao
        if (IsPerfectNumber(n))
        {
            Console.WriteLine($"{n} la So hoan hao!");
        }
        else
        {
            Console.WriteLine($"{n} KHONG la So hoan hao.");
        }

        // Kiem tra So nguyen to
        if (IsPrime(n))
        {
            Console.WriteLine($"{n} la So nguyen to.");
        }
        else
        {
            Console.WriteLine($"{n} KHONG la So nguyen to.");
        }

        // In day Fibonacci
        Console.Write($"Day Fibonacci {n} so: ");
        PrintFibonacci(n);
    }
}
