Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.\r\n");

Console.WriteLine("Введите целое неотрицательное число больше нуля:");

bool res = int.TryParse(Console.ReadLine(), out int number);
if (!res || number <= 0)
{
    Console.WriteLine("Ошибка ввода.\r\nВыполнение программы будет остановлено.");
    return;
}

Console.WriteLine("\r\nРезультат:");
string result = string.Empty;
int i = 1;
while (i <= number)
{
    if (i % 2 == 0)
    {
        if (result.Length == 0)
            result = i.ToString();
        else
            result += ", " + i.ToString();
    }

    i++;
}

Console.WriteLine(result);