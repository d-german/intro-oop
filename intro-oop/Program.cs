// See https://aka.ms/new-console-template for more information

using intro_oop;

Console.WriteLine("Hello, World!");

Console.WriteLine(new Circle(1.0).Area());

var location1 = new Location { X = 1.0, Y = 2.0 };
var location2 = new Location { X = 1.0, Y = 2.0 };

var areEqual = location1 == location2;

Console.WriteLine(areEqual);
