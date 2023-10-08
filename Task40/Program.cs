// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первую сторону: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую сторону: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью сторону: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}


bool res = IsExistTriangle(numA, numB, numC);

Console.WriteLine(res ? "Треугольник существует": "Треугольник не существует");



Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
46 -> 101110
13 -> 1101
2 -> 10

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
