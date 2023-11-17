namespace Tema1GDSC;

public class Rhombus : Shape
{
    private readonly double length;
    private readonly double angle;

    public Rhombus(double length, double angle)
    {
        if (length > 0 && angle >= 0 || angle <= 180)
        {
            this.length = length;
            this.angle = angle;
        }
        else
        {
            throw new NoSuchShapeException("There is no such a rhombus!");
        }
    }

    public void DrawShape()
    {
        Console.WriteLine("Rhombus: R = " + length);
    }

    public double GetSurface()
    {
        return length * length * double.Sin(angle);
    }
}