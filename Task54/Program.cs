//** Задача 54.** Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

//Исходный массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Результат:
//7 4 2 1
//9 5 3 2
//8 4 4 2


using System;
using static System.Console;
Clear();

int [,] matrix = new int[4,4];
FillMatrix(matrix);
PrintMatrix(matrix);
WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);



void SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1)-1; k++)
            {
                if (matr[i,k]<matr[i,k+1])
                {
                    int temp=matr[i,k+1];
                    matr[i,k+1]=matr[i,k];
                    matr[i,k]=temp;  
                }
            }
        }   
    }
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