// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = Prompt("Введите колличество строк: ");
int columns = Prompt("Введите колличество столбцов: ");
double[,] array = GetArray(rows, columns);
PrintArray(array);


double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             result[i, j] = new Random().NextDouble()*100-50; 
             result[i, j] = Math.Round(result[i, j], 1);
        }
    }
    return result;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            Console.Write(arr[i, j] + " ");

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