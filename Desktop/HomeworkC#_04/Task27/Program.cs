// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = Prompt("Введите число: ");
int sum = GetSum(number); 
Console.WriteLine($"{number} -> {sum}");

int GetSum(int num)
{
    int s = 0;
    while (num > 0)
    {
        s = num % 10 + s;
        num = num / 10;
    }
    return s;
}


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}