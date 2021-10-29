namespace GenericTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 3, 0, 3, 4, 5, 0, 10, 7, 6 };
            List<int> list2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            int max = HandyMethods.Max(list1);
            int min = HandyMethods.Min(list1);
            Console.WriteLine(max);
            Console.WriteLine(min);

            HandyMethods.Copy(array1, array2);
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i]);
            }
            HandyMethods.Shuffle(array2);
            Console.WriteLine("\nnow shuffled");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i]);
            }

            Console.WriteLine("\nPairs");
            Pair<string, int> pair = new Pair<string, int>("Hello", 42);
            Console.WriteLine($"{pair.value1} : {pair.value2}");
            Pair<int,string> swappedPair = pair.Swap();
            Console.WriteLine($"{swappedPair.value1} : {swappedPair.value2}");
        }
    }
}
