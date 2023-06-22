// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num = Promt("Введите натуральное число N: ");
double cubeNum = Cube(num);


double Cube(int number)
{
    double cube = 1;
    if(number > 0)
    {
        for(int i = 1; i <= number; i++)
        {
            cube = Math.Pow(i, 3);
            Console.Write(cube + " ");
        }
    
    }
    else Console.WriteLine("Число не является натуральным!");
    return cube;
}


int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}