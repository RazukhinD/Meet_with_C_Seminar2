using static System.Console;

Clear();
WriteLine("Введите трехзначное число :");
int number = int.Parse(ReadLine()!);
int a2 = number/100;

if (a2 ==0) // Знаю что не просили но мне нравится использовать return=))
{
    WriteLine("Вы ввели двухзначное число");
    return;
}

int a3 = number/1000; // Аналогично как и в комментарии сверху
if (a3 != 0)
{
    WriteLine("Вы ввели нетрехзначное число");
    return;
}

int a0 = number%10;

int a1 = (number-(a2*100+a0))/10;

WriteLine($" Вторая цифра числа {a1}");