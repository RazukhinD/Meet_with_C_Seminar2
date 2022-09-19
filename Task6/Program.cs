using static System.Console;

Clear();
WriteLine("Введи количество разрядов n: ");
int lenght = int.Parse(ReadLine()!);
int number = new Random().Next(10^(lenght-1),10^lenght);
WriteLine(number);

//int a0 = number%10;int a2 = number/100;int a1 = (number-(a2*100+a0));int result = a0*100+a1+a2;WriteLine($"{a2}{a0}");WriteLine(result);
