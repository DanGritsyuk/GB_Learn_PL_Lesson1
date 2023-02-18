bool done = false;
while (!done)
{
    Console.Clear();
    Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ");
    Console.WriteLine("");
    var tasksArray = new string[]
    {
    "Задача  2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.",
    "Задача  4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.",
    "Задача  6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).",
    "Задача  8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.",
    "Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.",
    "Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.",
    "Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.",
    "Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом."
    };

    int task = Lessons.StartMenu.GetMenu(tasksArray, true);

    Lessons.Exercise exercise;
    switch (task)
    {
        case 0: done = true; Console.Clear(); continue;
        case 1: exercise = new Lessons.Exercise2(task); break;
        case 2: exercise = new Lessons.Exercise4(task); break;
        case 3: exercise = new Lessons.Exercise6(task); break;
        case 4: exercise = new Lessons.Exercise8(task); break;
        case 5: exercise = new Lessons.Exercise10(task); break;
        case 6: exercise = new Lessons.Exercise13(task); break;
        case 7: exercise = new Lessons.Exercise15(task); break;
        default:
            Console.WriteLine("ЗАДАЧА ЕЩЕ НЕ РЕАЛИЗОВАНА");
            Console.ReadKey();
            continue;
    }
    exercise.Start();


    Console.WriteLine($"Программа закрыта.");
}