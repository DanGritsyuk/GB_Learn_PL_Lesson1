if (args.Length > 0)
    if (args[0].ToLower() == "edit")
    {
        Console.WriteLine(args[0]);
        Console.ReadKey();
    }

bool done = false;
while (!done)
{
    Console.Clear();
    Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ");
    Console.WriteLine("");

    Dictionary<int, string> tasksData = new Dictionary<int, string>();
    tasksData.Add(2, "Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    tasksData.Add(4, "Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    tasksData.Add(6, "Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    tasksData.Add(8, "Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    tasksData.Add(10, "Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    tasksData.Add(13, "Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    tasksData.Add(15, "Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    tasksData.Add(19, "Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    tasksData.Add(21, "Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    tasksData.Add(23, "Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

    var taskData = Lessons.StartMenu.GetMenu(tasksData, true);

    Lessons.Exercise exercise;
    switch (taskData.Key)
    {
        case 0: done = true; Console.Clear(); continue;
        case 2: exercise = new Lessons.Exercise2(taskData); break;
        case 4: exercise = new Lessons.Exercise4(taskData); break;
        case 6: exercise = new Lessons.Exercise6(taskData); break;
        case 8: exercise = new Lessons.Exercise8(taskData); break;
        case 10: exercise = new Lessons.Exercise10(taskData); break;
        case 13: exercise = new Lessons.Exercise13(taskData); break;
        case 15: exercise = new Lessons.Exercise15(taskData); break;
        case 19: exercise = new Lessons.Exercise19(taskData); break;
        case 21: exercise = new Lessons.Exercise21(taskData); break;
        case 23: exercise = new Lessons.Exercise23(taskData); break;
        default:
            Console.WriteLine("ЗАДАЧА ЕЩЕ НЕ РЕАЛИЗОВАНА");
            Console.ReadKey();
            continue;
    }
    exercise.Start();
}

Console.WriteLine($"Программа закрыта.");