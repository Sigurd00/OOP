using System.Runtime.Serialization;

[Serializable]
internal class InsufficientFundsException : Exception
{
    public InsufficientFundsException()
    {
        Console.WriteLine($"Insufficient funds");
    }

    public InsufficientFundsException(string? message) : base(message)
    {
    }
}