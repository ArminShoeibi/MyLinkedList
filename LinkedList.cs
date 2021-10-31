namespace MyLinkedList;

public class LinkedList<T>
{
    private Node _first;
    private Node _last;

    private class Node
    {
        public T _value;
        public Node _next;
        public Node(T value)
        {
            _value = value;
        }
    }
    public void AddLast(T item)
    {
        Node node = new(item);

        if (IsHeadNull())
            _first = _last = node;
        else
        {
            _last._next = node;
            _last = node;
        }
    }

    public void AddFirst(T item)
    {
        Node node = new(item);
        if (IsHeadNull())
            _first = _last = node;
        else
        {
            node._next = _first;
            _first = node;
        }
    }

    public int IndexOf(T item)
    {
        int index = 0;
        var current = _first;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current._value, item))
                return index;
            current = current._next;
            index++;
        }
        return -1;
    }

    public bool Contains(T item)
    {
        return IndexOf(item) != 1;
    }

    private bool IsHeadNull() => _first is null;
}
