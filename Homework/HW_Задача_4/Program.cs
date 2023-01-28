// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдает максимальное из этих чисел.

// Пример:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22




// _______________ЛУЧШИЙ ВАРИАНТ РЕШЕНИЯ (УЧИТЫВАЕТ ВСЕ ИСХОДЫ):___________________
System.Console.Write("Введите первое число: ");
double a = double.Parse(System.Console.ReadLine());

Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
double c = double.Parse(Console.ReadLine());

if (a > b && a > c)
{
    System.Console.WriteLine("Первое число наибольшее");
}
if (b > a && b > c)
{
    System.Console.WriteLine("Второе число наибольшее");
}
if (c > a && c > b)
{
    System.Console.WriteLine("Третье число наибольшее");
}
if (c == a && c == b)
{
    System.Console.WriteLine("Все числа равны");
}
if (a == b && a > c)
{
    System.Console.WriteLine("Первое и второе число наибольшие");
}
if (b > a && b == c)
{
    System.Console.WriteLine("Второе и третье число наибольшие");
}
// ________________________________________________________________________________






// _________________________НОРМАЛЬНЫЙ ВАРИАНТ РЕШЕНИЯ:____________________________


// System.Console.Write("Введите первое число: ");
// double a = double.Parse(System.Console.ReadLine());

// Console.Write("Введите второе число: ");
// double b = double.Parse(Console.ReadLine());

// Console.Write("Введите третье число: ");
// double c = double.Parse(Console.ReadLine());

// if (a > b && a > c)
// {
//     System.Console.WriteLine("Первое число наибольшее");
// }
// else
// {
//     if (b > a && b > c)
//     {
//         System.Console.WriteLine("Второе число наибольшее");
//     }
//     else
//     {
//         if (c > a && c > b)
//         {
//             System.Console.WriteLine("Третье число наибольшее");
//         }
//         else
//         {
//             System.Console.WriteLine("Есть одинаковые числа");
//         }
//     }
// }
// ________________________________________________________________________________





// _________________________ТУПОЙ ВАРИАНТ РЕШЕНИЯ:___________________________________

// System.Console.Write("Введите первое число: ");
// double a = double.Parse(System.Console.ReadLine());

// Console.Write("Введите второе число: ");
// double b = double.Parse(Console.ReadLine());

// Console.Write("Введите третье число: ");
// double c = double.Parse(Console.ReadLine());

// if (a > b)
// {
//     if (a > c)
//     {
//         System.Console.WriteLine("Первое число самое большое");
//     }
//     else
//     {
//         System.Console.WriteLine("Третье число самое большое");
//     }
// }
// else
// {
//     if (b > c)
//     {
//         System.Console.WriteLine("Второе число самое большое");
//     }
//     else
//     {
//         System.Console.WriteLine("Третье число самое большое");
//     }
// }
// ________________________________________________________________________________