internal class OutOfTonerException : Exception
{
    public OutOfTonerException()
    {
        Console.WriteLine("fix toner lol");
    }

    public OutOfTonerException(string? message) : base(message)
    {
    }

}