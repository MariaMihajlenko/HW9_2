//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
using System;
class Program
{
static void Main(string[] args)
{
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
int sum = 0;
if (M<N)
for (int i = N; i <= M; i++)
     sum+=i;
    Console.Write(sum);

if (M<N) 
for (int i = M; i <= N; i++)
    sum+=i;
    Console.Write(sum);
}
}

