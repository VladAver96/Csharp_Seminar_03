// Задача 2. Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int arraySize = 10;
        
        // Создаем массив и заполняем случайными трехзначными числами
        int[] array = new int[arraySize];
        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // Выводим массив на экран
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(array);

        // Находим и выводим количество четных чисел в массиве
        int evenCount = CountEvenNumbers(array);
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int CountEvenNumbers(int[] arr)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}

