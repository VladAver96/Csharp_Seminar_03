// Задача 3. Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int arraySize = 5;
        
        // Создаем массив и заполняем значениями
        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = i + 1; // Просто заполним массив числами от 1 до arraySize
        }

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Переворачиваем массив
        ReverseArray(array);

        // Выводим перевернутый массив на экран
        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            // Меняем местами значения на начальной и конечной позициях
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            // Переходим к следующей паре элементов
            start++;
            end--;
        }
    }
}

