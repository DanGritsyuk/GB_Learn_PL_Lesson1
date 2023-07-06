using Lessons;

int key = 0;
bool staredWithTask = false;
if (args.Length > 0)
{
    if (args[0].ToLower() == "edit")
        EditExerciseText.TryStratGetEditor();
    else
        staredWithTask = int.TryParse(args[0], out key);
}

bool done = false;
while (!done)
{
    var exercisesData = new ExerciseData();
    KeyValuePair<int, string> exerciseData;

    if (staredWithTask)
    {
        exerciseData = exercisesData.DataList.Where(item => item.Key == key).FirstOrDefault();
        staredWithTask = false;
        if (exerciseData.Key == 0) continue;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ");
        Console.WriteLine("");

        exerciseData = StartMenu.GetMenu(exercisesData, true);
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