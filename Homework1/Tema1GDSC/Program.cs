using Tema1GDSC;

var shapeRepository = new ShapeRepository(7);

var circle = new Circle(5);
var rhombus = new Rhombus(5, 120);
var square = new Square(5);
var triangle = new Triangle(2, 3, 4);

List<Shape> shapes = new List<Shape> { circle, triangle, rhombus, square };

Console.WriteLine("\nThe list of the shapes before adding the rectangle:");
foreach (var shape in shapes)
{
    Console.WriteLine(shape.GetType().Name);
}

var rectangle = new Rectangle(2, 4);

if (shapeRepository.AddShape(rectangle))
{
    shapes.Add(rectangle);
}

Console.WriteLine("\nThe list of the shapes after adding the rectangle:");
foreach (var shape in shapes)
{
    Console.WriteLine(shape.GetType().Name);
}

Console.WriteLine("\nThe list of the shapes after removing the rectangle:");
if (shapeRepository.RemoveShape(rectangle))
{
    shapes.Remove(rectangle);
}

foreach (var shape in shapes)
{
    Console.WriteLine(shape.GetType().Name);
}

Console.WriteLine("\nAll the shapes drawn: ");
shapeRepository.DrawAllShapes();
Console.WriteLine("\nThe total surface of all the shapes is: " + shapeRepository.GetTotalSurface());
Console.WriteLine("\nThe maximum surface of all the shapes is: " + shapeRepository.GetMaxSurface());
Console.WriteLine("\nHere you can see al the shapes:");
foreach (var shape in shapeRepository.GetAllShapes())
{
    Console.WriteLine(shape.GetType().Name);
}

Console.WriteLine("\nAll the shapes smaller than the given limit are:");
foreach (var shape in shapeRepository.GetAllShapesSmallerThan(10))
{
    Console.WriteLine(shape.GetType().Name);
}

Console.WriteLine("\n All the shapes mapped: ");
foreach (var shapePair in shapeRepository.MapAllShapesToType())
{
    Console.WriteLine($"{shapePair.Key}: {string.Join(", ", shapePair.Value.Select(s => s.GetType().Name))}");
}