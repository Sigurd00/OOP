public static class HandyMethods
{
    public static T Max<T>(List<T> list) where T : IComparable
    {
        T max = list[0];
        foreach (T item in list)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }
    public static T Min<T>(List<T> list) where T : IComparable
    {
        T min = list[0];
        foreach (T item in list)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }
        return min;
    }

    public static void Copy<T>(T[] array1, T[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("The arrays are not of the same length");
        }
        for (int i = 0; i < array1.Length; i++)
        {
            array2[i] = array1[i];
        }
    }

    public static void Shuffle<T>(T[] array)
    {
        Random rand = new Random();
        int min = 0;
        int i, j;
        T temp;
        int max = array.Length;
        for (int n = 0; n < array.Length; n++)
        {
            i = rand.Next(min, max);
            j = rand.Next(min, max);
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
