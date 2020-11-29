using System;
using _3_task.Classes;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Выберите массив с которым вы хотите работать, 1 или 2");
                Console.WriteLine("1: int[]");
                Console.WriteLine("2: string[]");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1) Console.WriteLine(1);
                while (number != 1 && number != 2)
                {
                    Console.WriteLine("только 1 или 2");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                if (number == 1)
                {
                    Console.WriteLine("Вы выбралт массив чисел\n");
                    Console.WriteLine("Вы выбрали массив строк");
                    int arraySize = Convert.ToInt32(Console.ReadLine());
                    ArrayWork arrayWork = new ArrayWork(arraySize);
                    Console.WriteLine($"Размер массива {arraySize}\n");
                    Console.WriteLine("Напишите индекс массива, чтобы увидеть элемент");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"В индексе {index} размещено {arrayWork[index]}\n");
                    Console.WriteLine("Если вы хотите изменить это значение, напишите новое значение, если не хотите напишите '0'");
                    int newValue = Convert.ToInt32(Console.ReadLine());
                    if (newValue != 0)
                    {
                        arrayWork[index] = newValue;
                        Console.WriteLine($"Вы успешно изменили значение в индексе {index} на {arrayWork[index]}");
                    }
                }
                else if (number == 2)
                {
                    Console.WriteLine("Вы выбралт массив чисел\n");
                    Console.WriteLine("Вы выбрали массив строк");
                    int arraySize = Convert.ToInt32(Console.ReadLine());
                    ArrayWorkStr arrayWork = new ArrayWorkStr(arraySize);
                    Console.WriteLine($"Размер массива {arraySize}\n");
                    Console.WriteLine("Напишите индекс массива, чтобы увидеть элемент");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"В индексе {index} размещено {arrayWork[index]}\n");
                    Console.WriteLine("Если вы хотите изменить это значение, напишите новое значение, если не хотите напишите '0'");
                    string newValue = Console.ReadLine();
                    if (newValue != "0")
                    {
                        arrayWork[index] = newValue;
                        Console.WriteLine($"Вы успешно изменили значение в индексе {index} on {arrayWork[index]}");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Значение должно быть числом");
            }
        }
    }

}
