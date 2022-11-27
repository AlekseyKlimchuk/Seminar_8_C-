//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
///Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
////27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Программа, которая будет построчно выводить массив, добавляя индексы каждого элемента");

int x = InputInt("Введите размерность 1: ");
int y = InputInt("Введите размерность 2: ");
int z = InputInt("Введите размерность 3: ");

Console.WriteLine("Массив и индексы: ");
int countNumbers = 50;

if (x * y * z > countNumbers)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Массив слишком большой!");
    return;
}

int[,,] numbers = CreateArr(x, y, z);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int k = 0; k < numbers.GetLength(2); k++)
        {
            Console.Write($"[{i},{j},{k}] {numbers[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] CreateArr(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] digitValues = new int[countNumbers];
    int value = 10;
    for (int i = 0; i < digitValues.Length; i++)
        digitValues[i] = value++;

    for (int i = 0; i < digitValues.Length; i++)
    {
        int randomIndex = new Random().Next(0, digitValues.Length);
        int temp = digitValues[i];
        digitValues[i] = digitValues[randomIndex];
        digitValues[randomIndex] = temp;
    }

    int valueIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = digitValues[valueIndex++];
            }
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    return array;
}


int InputInt(string output)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}