namespace Tema1GDSC;

class Triangle : Shape
{
    private readonly int sideA;
    private readonly int sideB;
    private readonly int sideC;

    public Triangle(int sideA, int sideB, int sideC)
    {
        if (sideA > 0 && sideB > 0 && sideC > 0)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        else
        {
            throw new NoSuchShapeException("There is no such a triangle!");
        }
    }

    public void DrawShape()
    {
        Console.WriteLine("Triangle: A = " + sideA + ",B = " + sideB + ",C = " + sideC);
    }

    public double GetSurface()
    {
        double semiPerimeter = (double)(sideA + sideB + sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
    }
}