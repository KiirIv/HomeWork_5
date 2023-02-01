/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] arr = new int[5];
Random rand = new Random();

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100);

        Console.Write(" " + array[i] + " ");

    }
    Console.Write("]");
}

void Main(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    Console.WriteLine($"min = {min}");

    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine($"max = {max}");
    int difference = max - min;
    Console.WriteLine($"разница равна  {difference}");
}

PrintArray(arr);
Console.WriteLine();
Main(arr);