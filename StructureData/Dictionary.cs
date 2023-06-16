namespace StructureData;

public class Dictionary<TKey, TValue>
{
    private readonly List<TKey> _keys;
    private readonly List<TValue?> _values;

    public int Count => _keys.Count;

    public Dictionary()
    {
        _keys = new List<TKey>();
        _values = new List<TValue?>();
    }

    public void Add(TKey key, TValue? value)
    {
        if (_keys.Contains(key))
            throw new ArgumentException("An item with the same key has already been added.");

        _keys.Add(key);
        _values.Add(value);
    }

    public bool Remove(TKey key)
    {
        var index = _keys.IndexOf(key);
        if (index < 0) return false;
        _keys.RemoveAt(index);
        _values.RemoveAt(index);
        return true;
    }

    public bool TryGetValue(TKey key, out TValue? value)
    {
        var index = _keys.IndexOf(key);
        if (index >= 0)
        {
            value = _values[index];
            return true;
        }
        value = default;
        return false;
    }
    
    public bool ContainsKey(TKey key)
    {
        return Enumerable.Contains(_keys, key);
    }

    public TValue? this[TKey key]
    {
        get
        {
            int index = _keys.IndexOf(key);
            if (index >= 0)
                return _values[index];
            throw new KeyNotFoundException("The given key was not present in the dictionary.");
        }
        set
        {
            int index = _keys.IndexOf(key);
            if (index >= 0)
                _values[index] = value;
            else
                Add(key, value);
        }
    }
}