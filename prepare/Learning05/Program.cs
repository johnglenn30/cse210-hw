using System;
using System.Collections.Generic;

namespace learn_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Learning05 World!");

            List<Shape> shapes = new List<Shape>();

            Circle circle = new Circle();
            circle.SetColor("Green");
            circle.SetRadius(6);
            shapes.Add(circle);

            // Assuming Rectangle and Square classes are implemented similarly
            Rectangle rectangle = new Rectangle();
            rectangle.SetColor("Blue");
            rectangle.SetWidth(4);
            rectangle.SetLength(5);
            shapes.Add(rectangle);

            Square square = new Square();
            square.SetColor("Red");
            square.SetSide(7);
            shapes.Add(square);

            foreach (Shape shape in shapes)
            {
                string color = shape.GetColor();
                double area = shape.GetArea();

                Console.WriteLine($"The {color} shape has an area of {area}.");
            }
        }
    }
}
