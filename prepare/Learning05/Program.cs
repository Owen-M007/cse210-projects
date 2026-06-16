using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 3);
        // Console.WriteLine(square1.GetColor());
        // Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("blue", 2, 4);
        // Console.WriteLine(rectangle1.GetColor());
        // Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("orange", 1);
        // Console.WriteLine(circle1.GetColor());
        // Console.WriteLine(circle1.GetArea());


        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(square1);
        shapeList.Add(rectangle1);
        shapeList.Add(circle1);

        foreach (Shape i in shapeList)
        {
        Console.WriteLine(i.GetColor());
        Console.WriteLine(i.GetArea());
        }
    }
}