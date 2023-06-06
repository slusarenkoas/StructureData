
namespace StructureData;

public class LinkedListGeneric <T>
{
    private List<T>? LinkedList { get; set; }

    public LinkedListGeneric()
    {
        LinkedList = new List<T>();
    }

    public int Count()
    {
        if (LinkedList != null) return LinkedList.Count;
        throw new ArgumentNullException(nameof(LinkedList), "LinkedList is null");
    }

    public void RemoveFirst()
    {
        LinkedList?.RemoveAt(0);
    }

    public void RemoveLast()
    {
        LinkedList?.RemoveAt(LinkedList.Count - 1);
    }
    
    public void AddAfter(T movableValue,T value)
    {
        if (LinkedList is { Count: 0 })
        {
            LinkedList.Add(value);
        }

        if (LinkedList == null) throw new ArgumentNullException(nameof(LinkedList), "LinkedList is null");
        for (var i = 0; i < LinkedList.Count - 1; i++)
        {
            if (!LinkedList[i]!.Equals(movableValue)) continue;
            LinkedList.Insert(i + 1, value);
            break;
        }

        throw new InvalidOperationException("Value not found in the LinkedList");
    }
    
    public void AddBefore(T movableValue,T value)
    {
        if (LinkedList is { Count: 0 })
        {
            LinkedList.Add(value);
        }

        if (LinkedList != null && LinkedList[0]!.Equals(movableValue))
        {
            LinkedList.Insert(0,value);
            return;
        }

        if (LinkedList == null) throw new ArgumentNullException(nameof(LinkedList), "LinkedList is null");
        for (var i = 1; i < LinkedList.Count; i++)
        {
            if (!LinkedList[i]!.Equals(movableValue)) continue;
            LinkedList.Insert(i, value);
            break;
        }

        throw new InvalidOperationException("Value not found in the LinkedList");
    }
    
    public void AddFirst (T value)
    {
        if (LinkedList is { Count: 0 })
        {
            LinkedList.Add(value);
        }
        
        LinkedList?.Insert(0,value);
    }

    public void AddLast(T value)
    {
        LinkedList?.Add(value);
    }
}