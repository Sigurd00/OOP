internal class IllegalDigitException : Exception
{
    public IllegalDigitException()
    {
        Console.WriteLine("Value of digit is not within the range of 0-9");
    }

    public IllegalDigitException(string? message) : base(message)
    {
    }

}