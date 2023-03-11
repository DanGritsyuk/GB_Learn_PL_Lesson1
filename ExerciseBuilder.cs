namespace Lessons
{
    public static class ExerciseBuilder
    {
        public static Exercise GetExerciseObject(KeyValuePair<int, string> exerciseData)
        {
            switch (exerciseData.Key)
            {
                case 2: return new Exercise2(exerciseData);
                case 4: return new Exercise4(exerciseData);
                case 6: return new Exercise6(exerciseData);
                case 8: return new Exercise8(exerciseData);
                case 10: return new Exercise10(exerciseData);
                case 13: return new Exercise13(exerciseData);
                case 15: return new Exercise15(exerciseData);
                case 19: return new Exercise19(exerciseData);
                case 21: return new Exercise21(exerciseData);
                case 23: return new Exercise23(exerciseData);
                case 25: return new Exercise25(exerciseData);
                case 27: return new Exercise27(exerciseData);
                case 29: return new Exercise29(exerciseData);
                case 34: return new Exercise34(exerciseData);
                case 36: return new Exercise36(exerciseData);
                case 38: return new Exercise38(exerciseData);
                case 41: return new Exercise41(exerciseData);
                case 43: return new Exercise43(exerciseData);
                case 47: return new Exercise47(exerciseData);
                case 50: return new Exercise50(exerciseData);
                case 52: return new Exercise52(exerciseData);
                case 54: return new Exercise54(exerciseData);
                case 56: return new Exercise56(exerciseData);
                case 57: return new Exercise57(exerciseData);
                case 58: return new Exercise58(exerciseData);
                case 60: return new Exercise60(exerciseData);
                case 62: return new Exercise62(exerciseData);
                case 64: return new Exercise64(exerciseData);
                case 66: return new Exercise66(exerciseData);
                case 68: return new Exercise68(exerciseData);
                default:
                    throw new Exception("ЗАДАЧА ЕЩЕ НЕ РЕАЛИЗОВАНА");
            }
        }
    }
}