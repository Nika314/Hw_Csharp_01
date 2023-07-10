// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

const int Row = 4;
const int Col = 5;
const int Min = 1;
const int Max = 20;

int[,] matrix = GetRandomMatrix(Row, Col, Min, Max);
PrintMatrix(matrix);
int[,] result = ResultArray(matrix);
Console.WriteLine();
PrintMatrix(result);

int[,] ResultArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}

int[,] GetRandomMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)    
        for (int j = 0; j < col; j++)
        matrix[i,j] = rnd.Next(min, max+1);
    return matrix;     
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++) 
       {
            Console.Write($"{matrix[i,j]} ");
       }
       Console.WriteLine();
    }
}

