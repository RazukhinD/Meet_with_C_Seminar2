using static System.Console;

Clear();
WriteLine("Введите трехзначное число :");
int number = int.Parse(ReadLine()!);
int a2 = number/100;

if (a2 ==0) 
{
    WriteLine("Такой цифры нет");
    return;
}


int temp1 = number/100;
a2 = temp1%10;
WriteLine($" Третья цифра числа {a2}");
