// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = Promt("Введите пятизначное число: ");
int reversenum = Reverse(num);
CheckPalindrom(num);


int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int Reverse(int number)
{
        int reverse = 0;
        if(number > 9999 && number < 100000)
        {
            for(int i = 0; i < 5; i++) 
            {
                reverse = reverse * 10 + number % 10;
                number = number / 10;
            }
                
                //Console.WriteLine(reverse);

        }
    else Console.WriteLine("Число не является пятизначным! ");
    return reverse;
}

void CheckPalindrom(int value)
{
    if(value > 9999 && value < 100000)
    {
        if(reversenum == value) {Console.WriteLine(value + " -> да");}
        else Console.WriteLine(value + " -> нет");
    }
    else Console.WriteLine("Введите пятизначное число: ");
}