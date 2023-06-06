
namespace StructureData;

public class StackGeneric <T>
{
    private List<T>? Stack { get; set; }

    public StackGeneric()
    {
        Stack = new List<T>();
    }

    public void Push(T value)
    {
        Stack?.Add(value);
    }

    public T Pop()
    {
        if (Stack == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        
        var current = Stack[^1];
        Stack.RemoveAt(Stack.Count-1);
        return current;
    }
    
    public T Peek()
    {
        if (Stack == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        
        return Stack[^1];
    }

    public void Clear()
    {
        Stack?.Clear();
    }

    public bool Contains(T value)
    {
        return Stack != null && Stack.Contains(value);
    }
    
    public int Count
    {
        get
        {
            if (Stack == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return Stack.Count;
        }
    }
}