// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите элементы массива через запятую:\nИсходный массив:");
        string[] inputArray = Console.ReadLine()!.Split(',');
        Console.WriteLine();
        Console.WriteLine(
            $"Итоговый массив:\n[{string.Join(
                ",", FilterStrings(inputArray))}]");
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;

        foreach (string item in inputArray)
        {
            if (item.Length <= 3) count++;
        }
        string[] resArray = new string[count];

        int index = 0;

        foreach (string item in inputArray)
        {
            if (item.Length <= 3) resArray[index++] = item;
        }

        return resArray;
    }
}
