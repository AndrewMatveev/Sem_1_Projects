// Задача 6: Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).

// Пример:
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Insert the number: ");
int a = Convert.ToInt32(Console.ReadLine());

int div = a % 2;

if (div == 0)
{
    System.Console.WriteLine("The number is even");
}
else
{
    System.Console.WriteLine("The number is odd");
}