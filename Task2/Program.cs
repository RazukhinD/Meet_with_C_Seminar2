using static System.Console;

Clear();
WriteLine("Введи первое число: ");
int number1 = int.Parse(ReadLine()!);
WriteLine("Введи второе число: ");
int number2 = int.Parse(ReadLine()!);

if (number2 == 0)
{
    WriteLine(" На 0 делить нельзя");
}
else 
{
    int div = number1%number2;

    if (div == 0)
    {
        WriteLine($"{number1} кратно {number2}");
    }
    else
    {
    WriteLine($"Остаток от деления {number1} на {number2}: {div}");
    }
}