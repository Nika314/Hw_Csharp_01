Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if(number % 2 == 0)
{
    Console.WriteLine(number + " - чётное");
}
else Console.WriteLine(number + " - нечётное");