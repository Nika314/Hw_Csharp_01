// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число диапазона массива: ");
int maxValue = Prompt("Введите максимальное число диапазона массива: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.Write($" -> {GetSumOdd(array)}");

int GetSumOdd(int[] arr)
{
    int sumOdd = 0;
    int[] result = new int[arr.Length];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = arr[i];
        if(i % 2 != 0)
        {
            sumOdd = sumOdd + result[i];
        }
    }    

    return sumOdd;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i =0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return result;
}

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i =0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}"); 
    Console.Write("]");
}