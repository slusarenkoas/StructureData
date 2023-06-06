namespace StructureData;

public class QueueGeneric <T>
{
    private List<T>? Queue { get; set; }

    public QueueGeneric()
    {
        Queue = new List<T>();
    }

    public void Push(T value)
    {
        Queue?.Add(value);
    }

    public T Pop()
    {
        if (Queue == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        
        var current = Queue[0];
        Queue.RemoveAt(0);
        return current;
    }
    
    public T Peek()
    {
        if (Queue == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        
        return Queue[0];
    }

    public void Clear()
    {
        Queue?.Clear();
    }

    public bool Contains(T value)
    {
        return Queue != null && Queue.Contains(value);
    }
    
    public int Count
    {
        get
        {
            if (Queue == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return Queue.Count;
        }
    }
}