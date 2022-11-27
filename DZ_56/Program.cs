//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Программа, которая будет находить строку с наименьшей суммой элементов массива");

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
int i = int.Parse(Console.ReadLine() ?? "0");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Задайте количество столбцов массива = ");
int j = int.Parse(Console.ReadLine() ?? "0");


int[,] arr = new int[i, j];

FillArray(arr);
PrintArray(arr);

int Sum(int[,] arr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += arr[i, j];
                minSum += arr[i, j];
            }
            else sum += arr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i;
        }
        sum = 0;
    }
    return minNum;
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Cтрока c наименьшей суммой элементов: {Sum(arr) + 1} строка");
