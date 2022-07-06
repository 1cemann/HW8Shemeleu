//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Массив A:
//6 0 2
//0 4 8
//0 7 9

//Массив В:
//0 0 3
//5 0 4
//8 2 0

//Результат
//16 4 18
//84 16 16
//107 18 28


using System;
using static System.Console;
Clear();

int [,] matrix1 = new int[3,3];
FillMatrix(matrix1);
PrintMatrix(matrix1);
WriteLine();
int [,] matrix2 = new int[3,3];
FillMatrix(matrix2);
PrintMatrix(matrix2);
WriteLine();
int [,] matrix3=Multiplication(matrix1,matrix2);
PrintMatrix(matrix3);

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                result[i,j]+=a[i,k]*b[k,j];
            }
        }
    }
    return result;
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







