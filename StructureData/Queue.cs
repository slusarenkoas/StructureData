namespace StructureData;

public class Queue<T>
{
    private Node<T>? First { get; set; }
    private Node<T>? Last { get; set; }
    private int Count { get; set; }

    public void Clear()
    {
        First = null;
        Last = null;
        Count = 0;
    }

    public bool Contains(T value)
    {
        if (First == null)
        {
            throw new InvalidOperationException("Queue is empty");
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

    public void Enqueue(T value)
    {
        var newNode = new Node<T>(value);
        
        if (First == null)
        {
            First = newNode;
            Last = First;
            Count++;
        }
        else
        {
            Last.Next = newNode;
            newNode.Previous = Last;
            Last = newNode;
            Count++;
        }
    }
    
    public T Dequeue()
    {
        if (First == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        var current = First;
        First = First.Next;
        if (First != null) First.Previous = null;
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
    /*public void Enqueue(Node<T> newNode)
    {
        if (First == null)
        {
            First = newNode;
            Last = First;
            Count++;
        }
        else
        {
            Last.Next = newNode;
            newNode.Previous = Last;
            Last = newNode;
            Count++;
        }
    }*/
}