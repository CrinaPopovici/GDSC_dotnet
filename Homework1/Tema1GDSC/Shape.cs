using System.Formats.Asn1;
using System.Collections;

namespace Tema1GDSC;

public interface Shape
{
    public void DrawShape();
    public abstract double GetSurface();
}