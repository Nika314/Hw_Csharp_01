// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = Prompt("Введите размерность массива: ");
int[] array = GetArray(size);
PrintArray(array);
Console.Write($" -> {NumberOfEven(array)}");

int NumberOfEven(int[] arr)
{
    int even = 0;
    int[] resultArr = new int[arr.Length];
    for(int i = 0; i < resultArr.Length; i++)
    {
        resultArr[i] = arr[i];
        if(resultArr[i] % 2 == 0)
        {
            even += 1;
        }
    }    

    return even;
}

int[] GetArray(int size)
{
    int[] result = new int[size];
    for(int i =0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000); 
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