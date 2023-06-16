namespace StructureData;

public class ListDynamicArray <T> where T : IComparable

{
    public int Count { get; private set; }
    public int Capacity { get; private set; }
    private T?[] DynamicArray { get; set; }
    
    public ListDynamicArray()
    {
        Capacity = 5;
        DynamicArray = new T?[Capacity];
        Count = 0;
    }

    public void Add (T? value)
    {
        if (Count == Capacity)
        {
            ResizeList();
        }
        
        DynamicArray[Count] = value;
        Count++;
    }

    public void Clear()
    {
        for (var i = 0; i < Count; i++)
        {
            DynamicArray[i] = default;
            Count = 0;
        }
    }

    public void Print()
    {
        for (var i = 0; i < Count; i++)
        { 
            Console.Write(DynamicArray[i] + " ");
        }

        Console.WriteLine();
    }

    public int IndexOf(T value)
    {
        for (var i = 0; i < Count; i++)
        {
            if (DynamicArray[i].Equals(value))
            {
                return i;
            }
        }
        
        throw new InvalidOperationException("Value not found in the list.");
    }

    public void Insert(int index, T value)
    {
        if (index < 0)
        {
            throw new InvalidOperationException("Index can't be negative");
        }
        
        if (Count == Capacity)
        {
            ResizeList();
        }
        
        if (index >= Count)
        {
            DynamicArray[Count] = value;
            Count++;
            return;
        }

        for (var i = Count + 1; i > index; i--)
        {
            DynamicArray[i] = DynamicArray[i - 1];
        }

        DynamicArray[index] = value;
        Count++;
    }

    public void Remove(T value)
    {
        for (var i = 0; i < Count; i++)
        {
            if (!DynamicArray[i].Equals(value)) continue;
            
            while (i != Count)
            {
                DynamicArray[i] = DynamicArray[i + 1];
                i++;
            }

            Count--;
            return;
        }
    }

    public void RemoveAt(int index)
    {
        for (var i = index; i <= Count; i++)
        {
            DynamicArray[i] = DynamicArray[i + 1];
        }
        
        Count--;
    }

    public void Sort()
    {
        QuickSort(0,Count-1);
    }

    public void Reverse()
    {
        var current = Count - 1;
        for (var i = 0; i < Count / 2; i++, current--)
        {
            (DynamicArray[i], DynamicArray[current]) = (DynamicArray[current], DynamicArray[i]);
        }
    }

    private void QuickSort(int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        var pivot = Partition(start, end);
        QuickSort(start,pivot - 1);
        QuickSort(pivot + 1,end);
    }

    private void ResizeList()
    {
        Capacity *= 2;

        T?[] temp = new T[Capacity];
        
        for (var i = 0; i < Count; i++)
        {
            temp[i] = DynamicArray[i];
        }

        DynamicArray = temp;
    }

    private int Partition(int start, int end)
    {
        
        var marker = start;
        
        for (var i = start; i < end; i++)
        {
            if (DynamicArray[i].CompareTo(DynamicArray[end]) < 0)
            {
                (DynamicArray[marker], DynamicArray[i]) = (DynamicArray[i], DynamicArray[marker]);
                marker++;
            }
        }

        (DynamicArray[marker], DynamicArray[end]) = (DynamicArray[end], DynamicArray[marker]);

        return marker;
    }
    
    public T this[int index]
    {
        get
        {
            if (index >= 0 && index < Count)
            {
                return DynamicArray[index];
            }

            throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < Count)
            {
                DynamicArray[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}