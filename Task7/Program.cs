using static System.Console;

Clear();
WriteLine("Введи количество разрядов n: ");
int lenght = int.Parse(ReadLine()!);
int number = new Random().Next(Convert.ToInt32(Math.Pow(10,lenght-1)),Convert.ToInt32(Math.Pow(10,lenght)));
WriteLine(number);
double new_number=0;
double coef = Math.Pow(10, lenght-1);
while (number != 0)
{
    new_number += (number % 10) * coef;
    number /= 10;
    coef /= 10;
}
WriteLine(new_number);
