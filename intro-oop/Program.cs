// See https://aka.ms/new-console-template for more information

using intro_oop;

var circle = new Circle(1.0);
var triangle = new Triangle(1.0, 2.0);

var shapes = new List<Shape> { circle, triangle };
var names = new List<INamable> { circle, triangle, new Dog() };

PrintArea(shapes);
PrintName(names);

void PrintArea(IEnumerable<Shape> shapes)
{
    foreach (var shape in shapes)
    {
        Console.WriteLine($"Area of {shape.GetName()} = {shape.Area()}");
    }
}

void PrintName(IEnumerable<INamable> namables)
{
    foreach (var namable in namables)
    {
        Console.WriteLine(namable.GetName());
    }
}
