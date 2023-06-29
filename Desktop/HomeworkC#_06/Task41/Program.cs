// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int M = Prompt("Введите количество элементов: ");
int[] array = EnterNumbers(M);
int count = CountOfPositive(array);
Print(array);
Console.Write(count);

int CountOfPositive(int[] arr)
{
    int count = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]>0) count+=1;
    }
    return count;
}

int[] EnterNumbers(int m)
{
    int[] arr = new int[m];
    for(int i=0; i<arr.Length; i++)
    {
        int number = Prompt($"Введите {i + 1}-й элемент: ");
        arr[i] = number;        
    }
    return arr;
}

void Print(int[] arr)
{
    Console.Write("[");
    for(int i=0; i<arr.Length-1; i++)
    {
         Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}] -> ");
}

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}