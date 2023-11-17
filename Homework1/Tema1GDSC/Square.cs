namespace Tema1GDSC;

class Square : Shape
{
    private readonly double length;

    public Square(double length)
    {
        if (length > 0)
        {
            this.length = length;
        }
        else
        {
            throw new NoSuchShapeException("There is no such a square!");
        }
    }

    public void DrawShape()
    {
        Console.WriteLine("Square: " + length + " x " + length);
    }

    public double GetSurface()
    {
        return length * length;
    }
}