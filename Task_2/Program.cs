// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите номер строки: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[3,4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(15);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

if (rowNumber > matrix.GetLength(0) || columnNumber > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {rowNumber} строки и {columnNumber} столбца равно {matrix[rowNumber-1,columnNumber-1]}");
}