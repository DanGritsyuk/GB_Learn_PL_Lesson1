using System.Reflection;
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
    KeyValuePair<int, string> execiseData;

    if (staredtWithTask)
    {
        execiseData = execisesData.DataList.Where(item => item.Key == key).FirstOrDefault();
        staredtWithTask = false;
        if (execiseData.Key == 0) continue;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ");
        Console.WriteLine("");

        execiseData = StartMenu.GetMenu(execisesData, true);
    }

    if (execiseData.Key != 0)
        try
        {
            Type exerciseType = Type.GetType($"Lessons.Exercise{execiseData.Key}")!;
            MethodInfo methodStart = exerciseType.GetMethod("Start", BindingFlags.Public | BindingFlags.Instance)!;
            ConstructorInfo exerciseConstructor = exerciseType.GetConstructor(new Type[] { typeof(KeyValuePair<int, string>) })!;
            object objExercise = exerciseConstructor.Invoke(new object[] { execiseData });
            methodStart.Invoke(objExercise, null);

        }
        catch
        {
            Console.WriteLine("ЗАДАЧА ЕЩЕ НЕ РЕАЛИЗОВАНА");
            Console.ReadKey();
            continue;
        }
    else
    {
        done = true;
        Console.Clear();
        continue;
    }
}

Console.WriteLine($"Программа закрыта.");