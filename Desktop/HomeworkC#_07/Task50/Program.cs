// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет

int numberOfRows = Prompt("Введите количество строк: ");
int numberOfColumns = Prompt("Введите номер столбца:  ");
int rows = Prompt("Введите номер строки: ");
int columns = Prompt("Введите номер столбца:  ");
int[,] array = GetArray(numberOfRows, numberOfColumns);
PrintArray(array);
GetValue(array, rows, columns);


void GetValue(int[,] arr, int m, int n)
{
    if(arr.GetLength(0) < m || arr.GetLength(1) < n)
    Console.WriteLine($"[{m}, {n}] -> на этой позиции числа в массиве нет");
    
    else Console.WriteLine($"На позиции [{m}, {n}] находится элмент {arr[m-1, n-1]}"); 
}


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-100, 101);
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