using static System.Console;

Clear();
WriteLine("Введи первое число: ");
int number1 = int.Parse(ReadLine()!);
WriteLine("Введи второе число: ");
int number2 = int.Parse(ReadLine()!);

if (number2 == 0)
{
    WriteLine(" 0 не является квадратом ни какого числа");
    return;
}

if (number1 == 0)
{
    WriteLine(" 0 не является квадратом ни какого числа");
    return;
}

if (number2>number1)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}

int sqrt = number2*number2;

if (sqrt == number1)
{
    WriteLine($"{number1} квадрат {number2}");
}
else
{
   WriteLine($"{number1} не является квадратом {number2}");
}
