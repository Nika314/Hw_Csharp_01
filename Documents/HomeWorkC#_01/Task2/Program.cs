Console.Clear();
Console.WriteLine("Введите два числа: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if(a > b)
{
  Console.WriteLine("max = "+ a + "  min = " + b);  
}
else if(a < b)
{
    Console.WriteLine("max = "+ b + "  min = " + a);
}
else Console.WriteLine("Числа равны");
