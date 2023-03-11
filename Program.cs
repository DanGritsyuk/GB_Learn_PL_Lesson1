using Lessons;

int key = 0;
bool staredtWithTask = false;
if (args.Length > 0)
{
    if (args[0].ToLower() == "edit")
        EditExerciseText.TryStratGetEditor();
    else
        staredtWithTask = int.TryParse(args[0], out key);
}

bool done = false;
while (!done)
{
    var execisesData = new ExeciseData();
    KeyValuePair<int, string> exerciseData;

    if (staredtWithTask)
    {
        exerciseData = execisesData.DataList.Where(item => item.Key == key).FirstOrDefault();
        staredtWithTask = false;
        if (exerciseData.Key == 0) continue;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ");
        Console.WriteLine("");

        exerciseData = StartMenu.GetMenu(execisesData, true);
    }

    if (exerciseData.Key == 0)
    {
        done = true;
        continue;
    }

    try
    {
        Exercise exercise = ExerciseBuilder.GetExerciseObject(exerciseData);
        exercise.Start();
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
        Console.ReadKey();

    }
}
Console.Clear();
Console.WriteLine($"Программа закрыта.");