// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.Write("Can you enter number:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DecimalToBinary(number));

int DecimalToBinary(int num)
{
    int result = 0;
    int mult = 1;
    while (num > 0)
    {
        result += num % 2 * mult;
        num = num / 2;// num /= 2 //
        mult *= 10;
    }
    return result;
}

