// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = Prompt("Введите натуральное число M: ");
int N = Prompt("Введите натуральное число N: ");
Console.Write(GetSum(M, N));

int GetSum(int m, int n)
{
    if(m == n) return n;
    return GetSum(m+1, n) + m;
}

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
