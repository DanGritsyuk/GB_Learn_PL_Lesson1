using Lessons;

if (args.Length > 0)
    if (args[0].ToLower() == "edit")
    {
        EditExerciseText.StratGetEditor();
    }

bool done = false;
while (!done)
{
    Console.Clear();
    Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ");
    Console.WriteLine("");

    Dictionary<int, string> tasksData = EditExerciseText.GetExerciseOptions();

    var taskData = StartMenu.GetMenu(tasksData, true);

    Exercise exercise;
    switch (taskData.Key)
    {
        case 0: done = true; Console.Clear(); continue;
        case 2: exercise = new Exercise2(taskData); break;
        case 4: exercise = new Exercise4(taskData); break;
        case 6: exercise = new Exercise6(taskData); break;
        case 8: exercise = new Exercise8(taskData); break;
        case 10: exercise = new Exercise10(taskData); break;
        case 13: exercise = new Exercise13(taskData); break;
        case 15: exercise = new Exercise15(taskData); break;
        case 19: exercise = new Exercise19(taskData); break;
        case 21: exercise = new Exercise21(taskData); break;
        case 23: exercise = new Exercise23(taskData); break;
        default:
            Console.WriteLine("ЗАДАЧА ЕЩЕ НЕ РЕАЛИЗОВАНА");
            Console.ReadKey();
            continue;
    }
    exercise.Start();
}

Console.WriteLine($"Программа закрыта.");