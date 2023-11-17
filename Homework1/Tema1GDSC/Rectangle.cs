namespace Tema1GDSC;

public class Rectangle : Shape
{
    private readonly double height;
    private readonly double width;

    public Rectangle(double height, double width)
    {
        if (height > 0 && width > 0)
        {
            this.height = height;
            this.width = width;
        }
        else
        {
            throw new NoSuchShapeException("There is no such a rectangle!");
        }
    }

    public void DrawShape()
    {
        Console.WriteLine("Rectangle: " + height + " x " + width);
    }

    public double GetSurface()
    {
        return height * width;
    }
}