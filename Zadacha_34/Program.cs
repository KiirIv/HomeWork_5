/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] arr = new int[4];
Random rand = new Random();

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 999);

        Console.Write(" " + array[i] + " ");

    }
    Console.Write("]");
}

void Even(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            ++count;
    }
    Console.WriteLine();
    Console.WriteLine($"количество четных чисел {count}");
}


PrintArray(arr);
Even(arr);