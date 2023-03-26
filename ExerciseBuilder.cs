namespace Lessons
{
    public static class ExerciseBuilder
    {
        public static Exercise GetExerciseObject(KeyValuePair<int, string> exerciseData)
        {
            switch (exerciseData.Key)
            {
                case 99: return new FinalProject(exerciseData);
                default:
                    throw new Exception("ЗАДАЧА ЕЩЕ НЕ РЕАЛИЗОВАНА");
            }
        }
    }
}