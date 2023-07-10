// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы: 
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int a = Prompt("Введите число строк 1-й матрицы (и строк 2-й): ");
int b = Prompt("Введите число столбцов 1-й матрицы и строк 2-й матрицы: ");
int c = Prompt("Введите число столбцов 2-й матрицы: ");
int Min = Prompt("Введите минимальное значение случайных чисел: ");
int Max = Prompt("Введите максимальное значение случайных чисел: ");
int[,] firstMatrix = GetRandomMatrix(a, b, Min, Max);
int[,] secondMatrix = GetRandomMatrix(b, c, Min, Max);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] resultMatrix= MultiplyMatrix(firstMatrix, secondMatrix);
PrintMatrix(resultMatrix);


int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }

    return resultMatrix;
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

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

