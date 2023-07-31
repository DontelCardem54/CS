using System;

int[] numbers = new int[] { 1, 3, 5, 7, 11, 13, 17 };

Console.WriteLine("Квадраты чисел");
Console.WriteLine();
Console.Write("Дан ряд чисел: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine();
Console.Write("Квадраты этих чисел: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i] * numbers[i]} ");
}