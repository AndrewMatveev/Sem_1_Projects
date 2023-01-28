// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N

// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


System.Console.Write("Insert the number: ");
int a = Convert.ToInt32(Console.ReadLine());

int div = a % 2;


if (div == 0 && a >= 2)
{
    System.Console.Write("Sequence of even numbers: ");
    for (int i = 2; i <= a; i = i + 2)
    {
        System.Console.Write(i + " ");
    }
}
else
{
    if (div == 1 && a >= 2)
    {
        for (int i = 2; i < a; i = i + 2)
        {
            System.Console.Write(i + " ");
        }
    }
    else
    {
        System.Console.WriteLine("The number entered is too small to display the sequence");
    }
}