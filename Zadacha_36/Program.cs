/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


int[] arr = new int[4];
Random rand = new Random();

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-100, 100);

        Console.Write($" {array[i]} ");

    }
    Console.Write("]");
}

void Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
        Console.WriteLine();
    }
    Console.WriteLine($"сумма элементов нечетных позиций равна {sum}");

}

PrintArray(arr);
Sum(arr);
