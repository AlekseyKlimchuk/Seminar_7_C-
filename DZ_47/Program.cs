Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Программа создания двумерного массива");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Задайте двумерный массив размером m x n");
int InputNumberFromConsole(string text)
{
    Console.Write(text + ": ");
    return int.Parse(Console.ReadLine());
}


void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() * 100 - 50;
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("{0:0.00}\t ", arr[i, j]);
        }
        Console.WriteLine();
    }
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
int m = InputNumberFromConsole("Введите размерность массива m");
Console.ForegroundColor = ConsoleColor.DarkBlue;
int n = InputNumberFromConsole("Введите размерность массива n");
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
