// Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArray(int length)
{
    double[] massiv = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        massiv[i] = rnd.Next(-5, 6) + rnd.NextDouble();
    }
    return massiv;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f1}\t");
    }
    System.Console.WriteLine();
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double[] massiv = CreateArray(6);
PrintArray(massiv);
double different = FindMax(massiv) - FindMin(massiv);
System.Console.WriteLine($"Разница между максимальным и минимальным числами массива равна :  {different:f2}");