namespace StructureData;

public class LinkedList <T>
{
    public Node<T>? First { get; set; }
    public Node<T>? Last { get; set; }
    public int Count { get; private set; }

    public LinkedList()
    {
        First = null;
        Last = null;
        Count = 0;
    }

    public void AddAfter(T movableValue, T value)
    {
        if (movableValue == null)
        {
            throw new ArgumentNullException(nameof(movableValue), "MovableValue is null");
        }
        
        var newNode = new Node<T>(value);

        if (First == null)
        {
            First = newNode;
            Last = newNode;
        }
        else
        {
            if (Last != null && movableValue.Equals(Last.Value))
            {
                Last.Next = newNode;
                newNode.Previous = Last;
                Last = newNode;
            }
            else
            {
                var current = First;
                while (current != null)
                {
                    
                    if (current.Value != null && current.Value.Equals(movableValue))
                    {
                        newNode.Next = current.Next;
                        newNode.Previous = current;
                        current.Next = newNode;
                        if (newNode.Next != null) newNode.Next.Previous = newNode;
                        break;
                    }
                    current = current.Next;
                }

                if (current == null)
                {
                    throw new InvalidOperationException("MovableValue not found in the linked list");
                }
            }
        }

        Count++;
    }
    
    public void AddBefore(T movableValue, T value)
    {

        if (movableValue == null)
        {
            throw new ArgumentNullException(nameof(movableValue), "MovableValue is null");
        }

        var newNode = new Node<T>(value);
        
        if (First == null)
        {
            First = newNode;
            Last = newNode;
        }
        else
        {
            if (movableValue.Equals(First.Value))
            {
                newNode.Next = First;
                First.Previous = newNode;
                First = newNode;
            }
            else
            {
                var current = Last;
                
                while (current != null)
                {
                    if (current.Value != null && current.Value.Equals(movableValue))
                    {
                        newNode.Next = current;
                        newNode.Previous = current.Previous;
                        current.Previous = newNode;
                        if (newNode.Previous != null) newNode.Previous.Next = newNode;
                        break;
                    }
                    current = current.Previous;
                }

                if (current == null)
                {
                    throw new InvalidOperationException("MovableValue not found in the linked list");
                }
            }
        }

        Count++;
    }

    public void RemoveFirst()
    {
        if (First == null)
        {
            throw new InvalidOperationException("Node is null");
        }

        if (First.Next == null)
        {
            First = null;
            Last = null;
            Count--;
            return;
        }

        First.Next.Previous = null;
        First = First.Next;
        Count--;
    }

    public void RemoveLast()
    {
        if (First == null)
        {
            throw new InvalidOperationException("Node is null");
        }

        if (First.Next == null)
        {
            First = null;
            Last = null;
            Count--;
            return;
        }

        if (Last?.Previous == null) return;
        Last.Previous.Next = null;
        Last = Last.Previous;
        Count--;
    }

    public void AddFirst(T value)
    {
        var node = new Node<T>(value);

        if (First == null)
        {
            First = node;
            Last = node;
        }
        else
        {
            node.Next = First;
            First.Previous = node;
            First = node;
        }

        Count++;
    }

    public void AddLast(T value)
    {
        var node = new Node<T>(value);

        if (First == null)
        {
            First = node;
            Last = node;
        }
        else
        {
            node.Previous = Last;
            if (Last != null) Last.Next = node;
            Last = node;
        }

        Count++;
    }

    /*public void AddFirst(Node<T>? node)
    {

        if (First == null)
        {
            First = node;
            Last = node;
        }
        else
        {
            if (node != null)
            {
                node.Next = First;
                First.Previous = node;
                First = node;
            }
        }

        Count++;
    }*/
    /*public void AddBefore(Node<T>? node, Node<T>? newNode)
    {

        if (node == null)
        {
            throw new ArgumentNullException(nameof(node), "Node is null");
        }
        
        if (First == null)
        {
            First = newNode;
            Last = newNode;
        }
        else
        {
            if (node == First)
            {
                if (newNode != null)
                {
                    newNode.Next = First;
                    First.Previous = newNode;
                    First = newNode;
                }
            }
            else
            {
                var current = Last;
                
                while (current != null)
                {
                    if (current.Value != null && current.Value.Equals(node.Value))
                    {
                        if (newNode != null)
                        {
                            newNode.Next = current;
                            newNode.Previous = current.Previous;
                            current.Previous = newNode;
                            if (newNode.Previous != null) newNode.Previous.Next = newNode;
                        }

                        break;
                    }
                    current = current.Previous;
                }

                if (current == null)
                {
                    throw new InvalidOperationException("Node not found in the linked list");
                }
            }
        }

        Count++;
    }*/
    /*public void AddLast(Node<T>? node)
    {
        if (First == null)
        {
            First = node;
            Last = node;
        }
        else
        {
            if (node != null)
            {
                node.Previous = Last;
                if (Last != null) Last.Next = node;
                Last = node;
            }
        }

        Count++;
    }*/
    /*public void AddAfter(Node<T>? node, Node<T>? newNode)
    {

        if (node == null)
        {
            throw new ArgumentNullException(nameof(node), "Node is null");
        }

        if (First == null)
        {
            First = newNode;
            Last = newNode;
        }
        else
        {
            if (node == Last)
            {
                Last.Next = newNode;
                if (newNode != null)
                {
                    newNode.Previous = Last;
                    Last = newNode;
                }
            }
            else
            {
                var current = First;
                
                while (current != null)
                {
                    if (current.Value != null && current.Value.Equals(node.Value))
                    {
                        if (newNode != null)
                        {
                            newNode.Next = current.Next;
                            newNode.Previous = current;
                            current.Next = newNode;
                            if (newNode.Next != null) newNode.Next.Previous = newNode;
                        }

                        break;
                    }
                    current = current.Next;
                }

                if (current == null)
                {
                    throw new InvalidOperationException("Node not found in the linked list");
                }
            }
        }

        Count++;
    }*/
}