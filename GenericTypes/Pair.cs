public class Pair<T1, T2> where T1 : IComparable where T2: IComparable
{
    public Pair(T1 value1, T2 value2) 
    {
        this.value1 = value1;
        this.value2 = value2;
    }

    public T1 value1 { get; }
    public T2 value2 { get; }

    public Pair<T2,T1> Swap()
    {
        return new Pair<T2, T1>(value2, value1);
    }
    public Pair<T1, T2> SetFst(T1 C)
    {
        return new Pair<T1, T2>(C, value2);
    }
    public Pair<T1, T2> SetSnd(T2 C)
    {
        return new Pair<T1, T2>(value1, C);
    }
}
