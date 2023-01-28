// Задача №3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// ___________________________________________________________________________

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (a == 2)
{
    System.Console.WriteLine("Вторник");
    }
if (a == 3)
{
    System.Console.WriteLine("Среда");
}
if (a == 4)
{
    System.Console.WriteLine("Четверг");
}
if (a == 5)
{
    System.Console.WriteLine("Пятница");
}
if (a == 6)
{
    System.Console.WriteLine("Суббота");
}
if (a == 7)
{
    System.Console.WriteLine("Воскресенье");
}
// ___________________________________________________________________________



// ___________________________________________________________________________
// Код Артема с оптимизайией и выводом ошибки при введени неправильного числа:

// System.Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if(day == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// else if(day == 2)
// {
//     System.Console.WriteLine("Вторник");
// }
// else if(day == 3)
// {
//     System.Console.WriteLine("Среда");
// }
// else if(day == 4)
// {
//     System.Console.WriteLine("Четверг");
// }
// else if(day == 5)
// {
//     System.Console.WriteLine("Пятница");
// }
// else if(day == 6)
// {
//     System.Console.WriteLine("Суббота");
// }
// else if(day == 7)
// {
//     System.Console.WriteLine("Воскресенье");
// }
// else
// {
//     System.Console.WriteLine("Такого дня недели не существует");
// }
// ___________________________________________________________________________



// ___________________________________________________________________________
// // Код со Switch:

// System.Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// switch (day)
// {
//     case 1:
//         System.Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         System.Console.WriteLine("Вторник");
//         break;
//     case 3:
//         System.Console.WriteLine("Среда");
//         break;
//     case 4:
//         System.Console.WriteLine("Четверг");
//         break;
//     case 5:
//         System.Console.WriteLine("Пятница");
//         break;
//     case 6:
//         System.Console.WriteLine("Суббота");
//         break;
//     case 7:
//         System.Console.WriteLine("Воскресенье");
//         break;
//     default:
//         System.Console.WriteLine("Такого дня недели не существует");
//         break;
// }
// ___________________________________________________________________________