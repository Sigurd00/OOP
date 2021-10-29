internal class IllegalGearChangeException : Exception
{
    public IllegalGearChangeException()
    {
        Console.WriteLine($"Gear change is not within one gear of the current gear");
    }

    public IllegalGearChangeException(string? message) : base(message)
    {
    }
}