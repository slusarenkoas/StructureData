namespace StructureData;

public class Stack <T>
{
    public Node<T>? First { get; private set; }
    public int Count { get; private set; }
    public void Push(T value)
    {
        var newNode = new Node<T>(value);
        
        if (First == null)
        {
            First = newNode;
            Count++;
        }
        else
        {
            newNode.Next = First;
            First = newNode;
            Count++;
        }
    }
    
    public T Pop()
    {
        if (First == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        var current = First;
        First = First.Next;
        if (First != null) First.Next = null;
        Count--;
        return current.Value;
    }

    public T Peek()
    {
        if (First == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return First.Value;
    }

    public void Clear()
    {
        First = null;
        Count = 0;
    }

    public bool Contains(T value)
    {
        if (First == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        var current = First;
        
        while (current != null)
        {
            if (value != null && value.Equals(current.Value))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }
    
    /*public void Push(Node<T> newNode)
    {
        if (First == null)
        {
            First = newNode;
            Count++;
        }
        else
        {
            newNode.Next = First;
            First = newNode;
            Count++;
        }
    }*/
}