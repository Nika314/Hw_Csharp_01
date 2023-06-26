// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = Prompt("Введите число А: ");
int b = Prompt("Введите натуральное число В: ");
int expon = Power(a, b);


int Power(int a, int b)
{
    int exp = 1;
    if(b > 0)
    {
        while(b > 0)
        {
            exp = exp * a;            
            b = b - 1;
        }

        Console.WriteLine($"Число A в натуральной степени B равно {exp}");
    }
    else Console.WriteLine("Число В не является натуральным числом!");
    
    return exp;
}


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}