using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Red", 5);
        Rectangle s2 = new Rectangle("Green", 4, 7);
        Circle s3 = new Circle("Blue", 8);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"This {shape.GetType()} is {shape.GetColor()} and has an area of {shape.GetArea():.}!");
        }
    }
}