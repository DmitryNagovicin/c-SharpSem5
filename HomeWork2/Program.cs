// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int length)
{
    int[] massiv = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        massiv[i] = rnd.Next(-100, 101);
    }
    return massiv;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int FindChet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] mas = CreateArray(5);
PrintArray(mas);
int result = FindChet(mas);
System.Console.WriteLine($"Сумма элементов, стоящих на четных позициях массива равна: {result}");

