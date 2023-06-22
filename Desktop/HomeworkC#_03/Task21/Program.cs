// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int xA = Promt("Введите координату X точки A: ");
int yA = Promt("Введите координату Y точки A: ");
int zA = Promt("Введите координату Z точки A: ");
Console.WriteLine();
int xB = Promt("Введите координату X точки B: ");
int yB = Promt("Введите координату Y точки B: ");
int zB = Promt("Введите координату Z точки B: ");

FindDistance(xA, yA, zA, xB, yB, zB);

void FindDistance(int XA, int YA, int ZA, int XB, int YB, int ZB)
{
    double AB = Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA)+(ZB-ZA)*(ZB-ZA));
    Console.WriteLine(AB);
}

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
