/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

Console.Write("Enter number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter number of colums: ");
int col = int.Parse(Console.ReadLine());
int[,] arr = FillArray(row, col);
Console.WriteLine("Sort array");
PrintArray(SortArrStr(arr));


void PrintArray(int [,] arr)
{

    for (int r = 0; r < arr.GetLength(0); r++)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            Console.Write($"{arr[r, c]} \t");
        }
        Console.WriteLine();
    }
}

int[,] SortArrStr(int[,] arr)
{

    for (int r = 0; r < arr.GetLength(0); r++)
    {
        int temp;
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            for (int cx = c + 1; cx < arr.GetLength(1); cx++)
            {
                if (arr[r, c] < arr[r, cx])
                {
                    temp = arr[r, c];
                    arr[r, c] = arr[r, cx];
                    arr[r, cx] = temp;
                }
            }
        }
    }
    return arr;
}

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