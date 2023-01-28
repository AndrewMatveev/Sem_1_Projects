// Задача 2: Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.

// Пример:
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// int.Parse() || Convert.ToInt32 // Конвертация из bool в Int

System.Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());

System.Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine("Первое число больше второго");
}
else
{
    if (a < b)
    {
        System.Console.WriteLine("Второе число больше первого");
    }
    else
    {
        System.Console.WriteLine("Числа равны");
    }
}