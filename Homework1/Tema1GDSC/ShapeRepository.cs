using System.Diagnostics.CodeAnalysis;

namespace Tema1GDSC;

public class ShapeRepository
{
    private Circle circle;
    private Rhombus rhombus;
    private Square square;
    private Triangle triangle;

    private List<Shape> shapesList;
    private readonly double limit;

    public ShapeRepository(double limit)
    {
        this.limit = limit;
        circle = new Circle(5);
        rhombus = new Rhombus(5, 120);
        square = new Square(5);
        triangle = new Triangle(2, 3, 4);
        shapesList = new List<Shape> { circle, triangle, rhombus, square };
    }

    public bool AddShape(Shape shape)
    {
        if (!(shape.GetSurface() > limit)) return false;
        shapesList.Add(shape);
        return true;
    }

    public bool RemoveShape(Shape shape)
    {
        if (shapesList.Remove(shape))
        {
            return true;
        }

        return false;
    }

    public void DrawAllShapes()
    {
        foreach (Shape shape in shapesList)
        {
            shape.DrawShape();
        }
    }

// Initial method
    // double GetTotalSurface()
    // {
    //     double sum=0;
    //         foreach (var shape in shapesList)
    //         {
    //             sum += shape.GetSurface();
    //         }
    //
    //     if (sum > 0)
    //     {
    //         return sum;
    //     }
    //     return 0;
    // }
//Simplified method:
    public double GetTotalSurface()
    {
        return shapesList.Sum(shape => shape.GetSurface());
    }

// Initial method
    // double GetMaxSurface()
    // {
    //     double max = 0;
    //         foreach (var shape in shapesList)
    //         {
    //             if (shape.GetSurface() > max)
    //             {
    //                 max = shape.GetSurface();
    //             }
    //         }
    //
    //     if (max > 0)
    //     {
    //         return max;
    //     }
    //
    //     return 0;
    // }
//Simplified method
    public double GetMaxSurface()
    {
        return shapesList.Max(shape => shape.GetSurface());
    }

    public List<Shape> GetAllShapes()
    {
        return shapesList;
    }

    public List<Shape> GetAllShapesSmallerThan(double upperLimit)
    {
        var shapesList1 = new List<Shape>();
        foreach (var shape in shapesList)
        {
            if (shape.GetSurface() < upperLimit)
            {
                shapesList1.Add(shape);
            }
        }

        return shapesList1;
    }

    public Dictionary<string, List<Shape>> MapAllShapesToType()
    {
        var shapeTypeMap = new Dictionary<string, List<Shape>>();

        var circleList = new List<Shape>();
        var triangleList = new List<Shape>();
        var rhombusList = new List<Shape>();
        var squareList = new List<Shape>();

        foreach (var shape in shapesList)
        {
            switch (shape.GetType().Name)
            {
                case "Circle":
                    circleList.Add(shape);
                    break;
                case "Triangle":
                    triangleList.Add(shape);
                    break;
                case "Rhombus":
                    rhombusList.Add(shape);
                    break;
                case "Square":
                    squareList.Add(shape);
                    break;
            }
        }

        shapeTypeMap.Add("Circle", circleList);
        shapeTypeMap.Add("Triangle", triangleList);
        shapeTypeMap.Add("Rhombus", rhombusList);
        shapeTypeMap.Add("Square", squareList);

        return shapeTypeMap;
    }
}