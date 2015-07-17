using System;

namespace Abstraction
{
    class FiguresExample
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle);
            Console.WriteLine();
            Rectangle rect = new Rectangle(2, 3);
            Console.WriteLine(rect);

            var secCercle = new Circle(-3);
            Console.WriteLine(secCercle);
        }
    }
}
