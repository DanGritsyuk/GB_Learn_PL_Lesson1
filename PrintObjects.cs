namespace Lessons
{
    public static class PrintObjects
    {
        public static void PrintArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }
        public static void PrintArray<T>(T[,] arr)
        {
            Console.WriteLine();
            for (int i = -1; i <= arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == -1 || i == arr.GetLength(0))
                        Console.Write("==");
                    else
                        Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}