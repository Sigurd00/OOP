internal class PaperJamException : Exception
{
    public PaperJamException()
    {
        Console.WriteLine("xD");
    }

    public PaperJamException(string? message) : base(message)
    {
    }
}