// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = Prompt("Введите размерность массива: ");
// double minValue = Prompt("Введите минимальное число диапазона массива: ");
// double maxValue = Prompt("Введите максимальное число диапазона массива: ");
double[] array = GetDoubleArray(size);
PrintArray(array);
Console.Write($" -> {GetDifference(array)}");

double GetDifference(double[] arr)
{
    double minValue = arr[0];
    double maxValue = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(minValue > arr[i]) minValue = arr[i];
        if(maxValue < arr[i]) maxValue = arr[i];
    }
    return maxValue-minValue;
}

double[] GetDoubleArray(int size)
{
    double[] result = new double[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().NextDouble() * 10 - 5; 
        result[i] = Math.Round(result[i], 3);
    }
    return result;
}
 
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}"); 
    Console.Write("]");
}