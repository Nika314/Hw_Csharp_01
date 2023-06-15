Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

for(int even_numbers = 1; even_numbers <= number; even_numbers++)
{
    if(even_numbers % 2 == 0)
    {
        Console.Write(even_numbers + " ");        
    }  
}

