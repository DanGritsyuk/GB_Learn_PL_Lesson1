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

    var execisesData = new ExeciseData();

    var execiseData = StartMenu.GetMenu(execisesData, true);

    Exercise exercise;
    switch (execiseData.Key)
    {
        case 0: done = true; Console.Clear(); continue;
        case 2: exercise = new Exercise2(execiseData); break;
        case 4: exercise = new Exercise4(execiseData); break;
        case 6: exercise = new Exercise6(execiseData); break;
        case 8: exercise = new Exercise8(execiseData); break;
        case 10: exercise = new Exercise10(execiseData); break;
        case 13: exercise = new Exercise13(execiseData); break;
        case 15: exercise = new Exercise15(execiseData); break;
        case 19: exercise = new Exercise19(execiseData); break;
        case 21: exercise = new Exercise21(execiseData); break;
        case 23: exercise = new Exercise23(execiseData); break;
        case 25: exercise = new Exercise25(execiseData); break;
        case 27: exercise = new Exercise27(execiseData); break;
        case 29: exercise = new Exercise29(execiseData); break;
        case 34: exercise = new Exercise34(execiseData); break;
        case 36: exercise = new Exercise36(execiseData); break;
        case 38: exercise = new Exercise38(execiseData); break;
        default:
            Console.WriteLine("ЗАДАЧА ЕЩЕ НЕ РЕАЛИЗОВАНА");
            Console.ReadKey();
            continue;
    }
    exercise.Start();
}

Console.WriteLine($"Программа закрыта.");