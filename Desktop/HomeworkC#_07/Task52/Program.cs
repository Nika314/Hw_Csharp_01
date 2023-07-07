// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int numberOfRows = Prompt("Введите количество строк: ");
int numberOfColumns = Prompt("Введите номер столбца:  ");
int min = Prompt("Введите min: ");
int max = Prompt("Введите max: ");
int[,] array = GetArray(numberOfRows, numberOfColumns, min, max);
PrintArray(array);
double[] average = GetAverage(array);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintResultArray(average);


double[] GetAverage(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            double sum = 0;            
            for(int i = 0; i < arr.GetLength(0); i++)
            {                               
                sum += arr[i,j];                             
            }
            result[j] = Math.Round(sum/arr.GetLength(0), 2);      
        }
       return result; 
    }
    
    
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1); 
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

void PrintResultArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++) 
    {        
        Console.Write(arr[i] + "   ");
    }
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}