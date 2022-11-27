//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Программа, которая заполнит спирально массив 4 на 4.");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Заполните спирально массив размером 4 на 4.");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\nВведите размер массива: ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];

int value = 1;
int i = 0;
int j = 0;

while (value <= size * size)
{
    array[i, j] = value;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++value;
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Заполненный спирально массив: ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
PrintArray(array);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
