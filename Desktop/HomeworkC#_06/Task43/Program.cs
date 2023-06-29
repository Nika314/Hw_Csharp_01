// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1 = Prompt("Введите b1");
double k1 = Prompt("Введите k1");
double b2 = Prompt("Введите b2");
double k2 = Prompt("Введите k2");
Intersection(b1, k1, b2, k2);

double Prompt(string message)
{
    Console.WriteLine(message);
    double number = double.Parse(Console.ReadLine()!);
    return number;
}

void Intersection(double b1, double k1, double b2, double k2)
{
    double x = 1;
    double y = 1;
    if(k1==k2 && k1==0 && b1!=b2)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    else if(k1==k2 && b1==b2)
    {
        Console.WriteLine("Точек пересечения бесконечное множество");
    }
    else if(k1!=k2 && b1==b2 && b1==0)
    {
        Console.WriteLine("Прямые не пересекаются");
    }   
    else
    {
        x = (b2 - b1)/(k1-k2); 
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
    }
}
