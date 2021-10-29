
public class Dict<K, V> where K: IComparable where V: IComparable
{
    List<Pair<K,V>> pairs = new List<Pair<K,V>>();

    public Pair<K,V> Get(K key)
    {
        for (int i = 0; i < pairs.Count; i++)
        {
            if(pairs[i].value1.CompareTo(key) == 0)
            {
                return pairs[i];
            }
        }
        throw new Exception("bonkers, could not find a matching key in that list");
    }

    public void Put(K key, V value)
    {
        for (int i = 0; i < pairs.Count; i++)
        {
            if (pairs[i].value1.CompareTo(key) == 0)
            {
                pairs[i].SetFst(key);
                pairs[i].SetSnd(value);
                return;
            }
        }
        pairs.Add(new Pair<K, V>(key, value));
    }
}