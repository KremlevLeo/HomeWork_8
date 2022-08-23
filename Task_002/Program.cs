/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Write("Enter number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter number of colums: ");
int col = int.Parse(Console.ReadLine());
int[,] arr = FillArray(row, col);
int res = FaindRow(SumOfRow(arr));
Console.WriteLine(res);


int[,] FillArray(int row, int col)
{
    int[,] arr = new int[row, col];
    Random rnd = new Random();
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            arr[r, c] = rnd.Next(1, 10);
            Console.Write($"{arr[r, c]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return arr;
}

int[] SumOfRow(int[,] arr)
{
    int[] sum = new int[arr.Length];
    int tmp;
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        tmp = 0;
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            tmp += arr[r, c];
        }
        sum[r] = tmp;
    }
    return sum;
}
int FaindRow(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int min = arr[0];
        if (min > arr[i])
        {
            min = arr[i];
        }
        int index = Array.IndexOf(arr, min);
        return index;
    }
    return -1;
}