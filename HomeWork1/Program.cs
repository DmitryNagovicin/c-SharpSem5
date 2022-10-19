// Задача 1: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет
//  количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(int length)
{
    int[] massiv = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        massiv[i] = rnd.Next(100, 1001);
    }
    return massiv;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int FindChet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}

int[] mas = CreateArray(10);
PrintArray(mas);
int result = FindChet(mas);
System.Console.WriteLine($"В массиве {result} четных чисел(а)");