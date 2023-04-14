/*
Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

using static System.Console;

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");
    }
    WriteLine();
  }
}

Write("Введите количество строк массива: ");
int rowsDefault = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columnsDefault = int.Parse(ReadLine()!);
int[,] array = GetArray(rowsDefault, columnsDefault, 0, 10);
PrintArray(array);

Write("Введите через пробел позицию элемента: ");
string[] str = ReadLine()!.Split(" ");
int rowsEnter = int.Parse(str[0]) - 1;
int columnsEnter = int.Parse(str[1]) - 1;

if ((rowsEnter < rowsDefault) && (columnsEnter < columnsDefault))
{
  WriteLine($"Значение: {array[rowsEnter, columnsEnter]}");
}
else
{
  WriteLine("Такого элемента не существует.");
}
