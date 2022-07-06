//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Исходный массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Результат:
//1-строка

using System;
using static System.Console;
Clear();

int [,] matrix = new int[4,4];
FillMatrix(matrix);
PrintMatrix(matrix);
WriteLine();

int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
WriteLine($"{minSumLine+1}-строкa");




int SumLineElements(int[,] matr, int i)
{
  int sumLine = matr[i,0];
  for (int j = 1; j < matr.GetLength(1); j++)
  {
    sumLine += matr[i,j];
  }
  return sumLine;
}

void FillMatrix(int[,] newmatr)
{
    for (int i = 0; i < newmatr.GetLength(0); i++)
    {
        for (int j = 0; j < newmatr.GetLength(1); j++)
        {
            newmatr[i,j]=new Random().Next(0,10);   
        }
        
    }
}

void PrintMatrix(int[,] newmatr)
{
    for (int i = 0; i < newmatr.GetLength(0); i++)
    {
        for (int j = 0; j < newmatr.GetLength(1); j++)
        {
            Write($"{newmatr[i,j]} ");
        }
        WriteLine();   
    }
}