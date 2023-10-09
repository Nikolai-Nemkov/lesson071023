// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 44")

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5
// (фибоначи начинается с 3й цифры. до нее это 0 и 1, и следующая цифра это сумма 2х предыдущих

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] FiboArray(int num)
{
    int[] arr = new int[num];
    // arr[0] = 0; массив по умолчанию заполнен нолями, нет смысла при сваивать.
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]} ");
    }
}

int number = Prompt("Введите число больше 1 : ");
if (number < 2)
{
    Console.WriteLine("Некорректный ввод.");
    return;
}
int[] fiboArray = FiboArray(number);

PrintArray(fiboArray);
