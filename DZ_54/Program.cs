//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива");
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{arr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Задайте количество строк массива = ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
int i = int.Parse(Console.ReadLine() ?? "0");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Задайте количество столбцов массива = ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
int j = int.Parse(Console.ReadLine() ?? "0");


int[,] arr = new int[i, j];

FillArray(arr);
PrintArray(arr);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(arr);
WriteArray(arr);

void OrderArrayLines(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}
void WriteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{arr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}