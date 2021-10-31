namespace MyLinkedList;

public class LinkedList<T>
{
    private Node _first;
    private Node _last;
    private int _count;

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
        _count++;
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
        _count++;
    }

    public int IndexOf(T item)
    {
        int index = 0;
        var current = _first;
        while (current is not null)
        {
            if (EqualityComparer<T>.Default.Equals(current._value, item))
                return index;
            current = current._next;
            index++;
        }
        return -1;
    }

    public bool Contains(T item) => IndexOf(item) != -1;

    public void RemoveFirst()
    {
        if (IsHeadNull())
            throw new InvalidOperationException();

        if (_first == _last)
            _first = _last = null;
        else
        {
            var secondNode = _first._next;
            _first._next = null;
            _first = secondNode;
        }
        _count--;
    }

    public void RemoveLast()
    {
        if (IsHeadNull())
            throw new InvalidOperationException();

        if (_first == _last)
            _first = _last = null;
        else
        {
            var previousNode = GetPrevious(_last);
            previousNode._next = null;
            _last = previousNode;
        }
        _count--;
    }

    public int Count() => _count;
    public T[] ToArray()
    {
        T[] array = new T[_count];
        var current = _first;
        var index = 0;
        while (current is not null)
        {
            array[index++] = current._value;
            current = current._next;
        }
        return array;
    }

    private bool IsHeadNull() => _first is null;
    private Node GetPrevious(Node node)
    {
        var current = _first;
        while (current is not null)
        {
            if (current._next == node)
                return current;

            current = current._next;
        }
        return null;
    }
}
