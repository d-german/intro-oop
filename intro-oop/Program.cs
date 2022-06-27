// See https://aka.ms/new-console-template for more information

using intro_oop;

var circle = new Circle(1.0);
var triangle = new Triangle(1.0, 2.0);

var shapes = new List<Shape> { circle, triangle };

PrintArea(shapes);

void PrintArea(IEnumerable<Shape> shapes)
{
    foreach (var shape in shapes)
    {
        Console.WriteLine(shape.Area());
    }
}
