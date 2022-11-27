//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Программа, которая будет находить произведение двух матриц.");


int InputInt(string output)
{
    Console.Write(output);
    
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.ForegroundColor = ConsoleColor.Blue;
int size = InputInt("Размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);

int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);

