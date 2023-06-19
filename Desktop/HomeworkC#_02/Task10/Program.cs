// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if(number >= 100 && number < 1000)
{
    Console.WriteLine(number%10);
}
else Console.WriteLine("Ошибка!");