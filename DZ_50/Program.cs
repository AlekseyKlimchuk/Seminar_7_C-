//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет




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

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Задайте позицию элемента в строке = ");
int numberI = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Задайте позицию элемента в столбце = ");
int numberJ = int.Parse(Console.ReadLine() ?? "0");

if(numberI>=i || numberJ>=j)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"Значение элемента выходят за размер массива");
    return;
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"Значение элемента ({numberI},{numberJ}) = {arr[numberI,numberJ]}");

