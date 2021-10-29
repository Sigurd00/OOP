internal class OutOfPaperException : Exception
{
    public OutOfPaperException()
    {
        Console.WriteLine("No paper lol");
    }

    public OutOfPaperException(string? message) : base(message)
    {
    }
}