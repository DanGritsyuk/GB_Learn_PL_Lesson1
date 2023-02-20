// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
namespace Lessons
{
    public class Exercise21 : Exercise
    {
        public Exercise21(int taskNum, string description) : base(taskNum, description) { }
        public Exercise21(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }

        public override void Body()
        {
            Console.WriteLine("Первая точка в пространстве. ");
            var point1In3D = new Point3D();
            Console.WriteLine("Вторая точка в пространстве. ");
            var point2In3D = new Point3D();

            Console.WriteLine();
            Console.WriteLine($"Расстояние между A{point1In3D.ToString()} и B{point2In3D.ToString()} равно {double.Round(Point3D.GetDistance(point1In3D, point2In3D), 2)}");
        }

        struct Point3D
        {
            string errorMessage = "Введено некоректное число.";
            public Point3D()
            {
                Console.WriteLine("Введите координаты: ");
                Console.Write("x= "); this.x = InputNumbers.GetNumberFromConsole<int>(errorMessage);
                Console.Write("y= "); this.y = InputNumbers.GetNumberFromConsole<int>(errorMessage);
                Console.Write("z= "); this.z = InputNumbers.GetNumberFromConsole<int>(errorMessage);
                Console.WriteLine();
            }

            public double x;
            public double y;
            public double z;

            public static double GetDistance(Point3D point1, Point3D point2) =>
                Math.Sqrt(Math.Pow(point2.x - point1.x, 2) + Math.Pow(point2.y - point1.y, 2) + Math.Pow(point2.z - point1.z, 2));

            public override string ToString() => $"({x}; {y}; {z})";
        }
    }
}