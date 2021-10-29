public class DigitalDisplay
{
    //12:30
    private List<int> _digits = new List<int>
    {
        1,
        2,
        3,
        0
    };

    public DigitalDisplay()
    {
    }
    public int GetDigit(int i)
    {
        if (NoSuchDigit(i))
        {
            throw new NoSuchDigitException();
        }
        return _digits[i];
    }
    public void SetDigit(int i, int v)
    {
        if (NoSuchDigit(i))
        {
            throw new NoSuchDigitException();
        }
        else if (v < 0 || v > 9)
        {
            throw new IllegalDigitException();
        }
        _digits[i] = v;
    }


    private bool NoSuchDigit(int i)
    {
        return (i < 0 || i > 3);
    }
}
