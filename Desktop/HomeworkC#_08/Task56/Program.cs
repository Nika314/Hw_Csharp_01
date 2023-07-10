// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

const int Row = 3;
const int Col = 4;
const int Min = 1;
const int Max = 10;

int[,] matrix = GetRandomMatrix(Row, Col, Min, Max);
PrintMatrix(matrix);
int minRow = MinSumOfRow(matrix);
Console.WriteLine();
Console.WriteLine($"{minRow+1} - строкa с наименьшей суммой ({SumOfRow(matrix, minRow)}) элементов. ");


int MinSumOfRow(int[,]array)
{
    int index = 0;
    int minSumRow = SumOfRow(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow = SumOfRow(array, i);
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            index = i;
        }
    }
    return index;
}

int SumOfRow(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
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

