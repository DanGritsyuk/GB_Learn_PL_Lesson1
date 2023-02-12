bool done = false;
while (!done)
{
    Console.Clear();
    Console.WriteLine(@"Домашнее задание №1
Задача  2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Задача  4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Задача  6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Задача  8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

0 - выход из программы.
");
    bool correct = false;
    while (!correct)
    {
        Console.Write("Введите номер задачи: ");
        int task = Lesson1.InputNumbers.GetNumberFromConsole();

        Lesson1.Exercise exercise;
        switch (task)
        {
            case 0: done = true; correct = true; Console.Clear(); continue;
            case 2: exercise = new Lesson1.Exercise2(task); break;
            case 4: exercise = new Lesson1.Exercise4(task); break;
            case 6: exercise = new Lesson1.Exercise6(task); break;
            case 8: exercise = new Lesson1.Exercise8(task); break;
            case 10: exercise = new Lesson1.Exercise10(task); break;
            case 13: exercise = new Lesson1.Exercise13(task); break;
            case 15: exercise = new Lesson1.Exercise15(task); break;
            default:
                Console.Write("Такой задачи нет. ");
                continue;
        }
        exercise.Start();
        correct = true;
    }

    Console.WriteLine($"Прорамма закрыта.");
}