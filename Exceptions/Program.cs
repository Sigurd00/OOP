public class Program
{
    public static void Main(string[] args)
    {
        int ReadInteger()
        {
            string result = Console.ReadLine();
            int intresult = 0;
            if (!int.TryParse(result, out int value))
                throw new Exception("Input is not an integer");
            intresult = int.Parse(result);
            if (intresult < 0)
                throw new ArgumentOutOfRangeException();
            return intresult;
        }

        try
        {
            ReadInteger();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
