// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using System;

class Program 
{
    public static int Main() 
    {
        Console.WriteLine("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for(int i=1; i<n; i++)
         {
            if(i%2 == 0) 
            {
                Console.WriteLine("{0}", i);
            }
        }
        Console.ReadKey();
        return 0;
    }
}
