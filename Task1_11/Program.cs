using System;
using log;

namespace Task1_11
{
    internal class Program
    {
        //Todo: почему нельзя сделать Console.Read(), а нужно ReadLine???
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Найти площадь заштрихованной фигуры, если известна только сторона квадрата");
            Console.WriteLine("Введите значение длины стороны квадрата: ");
            double a;
            string ans = Console.ReadLine();
            
            if (!double.TryParse(ans, out a))
            {
                Console.WriteLine("Неверные данные");
            }
            else
            {
                var b = new Logic();
                Console.WriteLine("Искомая площадь: " + b.findSquare(a));
            }
        }
    }
}