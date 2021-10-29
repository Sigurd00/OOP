internal class NoSuchDigitException : Exception
{
    public NoSuchDigitException()
    {
        Console.WriteLine("Digit is not within 0-3 range");
    }

    public NoSuchDigitException(string? message) : base(message)
    {
    }
}