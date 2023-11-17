namespace Tema1GDSC;

public class Circle : Shape
{
    private readonly double radius;
    private const double Pi = 3.1415926535897931;

    public Circle(double radius)
    {
        if (radius > 0)
        {
            this.radius = radius;
        }
        else
        {
            throw new NoSuchShapeException("There is no such a circle!");
        }
    }

    public void DrawShape()
    {
        Console.WriteLine("Circle: R = " + radius);
    }

    public double GetSurface()
    {
        return Pi * radius * radius;
    }
}