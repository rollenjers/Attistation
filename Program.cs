using System;

class Program
{
    static void Main()
    {
        // Ввод массива с клавиатуры
        Console.Write("Введите количество строк: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] inputArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            inputArray[i] = Console.ReadLine();
        }

        // Подсчитываем количество строк, длина которых <= 3
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив для строк, длина которых <= 3
        string[] resultArray = new string[count];

        // Заполняем новый массив
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(inputArray);

        // Выводим результат
        Console.WriteLine("Новый массив (строки длиной <= 3):");
        PrintArray(resultArray);
    }

    // Метод для вывода массива на экран
    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("\"" + array[i] + "\"");
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}