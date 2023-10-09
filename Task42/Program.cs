// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 42");

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DecimalToBinary(number));

int DecimalToBinary(int num) // DecimalToBinary перевод как "ДесятичноеДвоичное"
{
    int result = 0;
    int mult = 1;
    while (num > 0) // метод for используем когда нам известно количество операций
    // а while когда неизвестно.
    {
        result += num % 2 * mult; // цикл деления будет до 0. если при делении будет четное, ставим -0, нечетное -1
        num = num / 2; // num /= 2
        mult *= 10; //
    }
    return result;
}

/*
2й вариант решения, меняем метод.


string DecimalToBinaryStr(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;   // num /= 2 //
    }
    return result;
}

*/
