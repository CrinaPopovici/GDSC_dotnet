using System.Transactions;

namespace Tema1GDSC;

public class NoSuchShapeException : Exception
{
    public NoSuchShapeException(string message) : base(message)
    {
    }
}