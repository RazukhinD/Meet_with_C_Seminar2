using static System.Console;

Clear();
Write("Введите номер дня недели: ");
int num1 = Convert.ToInt32(ReadLine()!);

if (num1<1 || num1>7)
{
    WriteLine("Введи правильный номер");
    return;
}
if (num1 == 6 || num1 == 7)
{
    WriteLine("Выходной");
    return;
}
WriteLine("Будний");
