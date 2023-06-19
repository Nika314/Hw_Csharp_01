// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7, которая соответствует дню недели: ");
int number = int.Parse(Console.ReadLine()!);

 if(number > 0 && number < 8)
 {
    if(number < 6) {Console.WriteLine("Придётся поработать!");}
    else Console.WriteLine("Выходной!");
 } 
else Console.WriteLine("Это не день недели!");