//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.





void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
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




void AvrArr(double[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Среднее арифметическое:");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double summ = 0;
        int count = 0;
        double average = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            summ = summ + arr[i, j];
            count++;
        }
        average = summ / count;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"{average}\t");
    }
}
double[,] arr = new double[10, 10];


FillArray(arr);
PrintArray(arr);
AvrArr(arr);