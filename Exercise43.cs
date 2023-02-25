// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

namespace Lessons
{
    public class Exercise43 : Exercise
    {
        public Exercise43(KeyValuePair<int, string> taskData) : base(taskData) { }

        public override void Body()
        {
            var line1 = new GeometryLine("1");
            var line2 = new GeometryLine("2");

            if (line1.Coefficient == line2.Coefficient)
            {
                if (line1.Constant == line2.Constant)
                    Console.WriteLine("Прямые совпадают.");
                else
                    Console.WriteLine("Прямые параллельные.");
                return;
            }

            var intersectionPoint = new Point(line1, line2);
            Console.WriteLine($"Точка пересечения имеет координаты {intersectionPoint.ToString()}");
        }

        public struct GeometryLine
        {
            public GeometryLine(string name)
            {
                string errorMessage = "Некоректное значение";

                this.Name = name;
                Console.WriteLine($"Введите коэфицент для прямой {name}");
                this.Coefficient = InputNumbers.GetNumberFromConsole<double>(errorMessage);
                Console.WriteLine($"Введите константу для прямой {name}");
                this.Constant = InputNumbers.GetNumberFromConsole<double>(errorMessage);
            }

            public string Name;
            public double Coefficient;
            public double Constant;
        }

        public struct Point
        {
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public Point(GeometryLine l1, GeometryLine l2)
            {
                this.x = (l1.Constant - l2.Constant) / (l2.Coefficient - l1.Coefficient);
                this.y = l1.Coefficient * this.x + l1.Constant;
            }
            public double x;
            public double y;

            public override string ToString()
            {
                return $"({this.x}; {this.y})";
            }
        }
    }


}