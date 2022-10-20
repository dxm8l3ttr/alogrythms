using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Algorythms.Core;

internal sealed class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Next { get; set; }
    
    public Node(T value, Node<T>? next=null)
    {
        Next = next;
        Value = value;
    }
}

public class SingleLinkedList<T> : IList<T>
{
    private Node<T> firstNode;
    private Node<T> lastNode;
    private int _count;

    public SingleLinkedList()
    {
        _count = 0;
    }
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private Node<T> GetNodeAt(int index)
    {
        if (index == 0)
        {
            return firstNode;
        }
        if (index == Count - 1)
        {
            return lastNode;
        }
        var node = firstNode;
        foreach(var i in ..(index - 1))
        {
            node = node.Next;
        }

        return node;
    }

    private Node<T> NodeWithValue(T value)
    {
        var node = firstNode;
        foreach (var i in .._count)
        {
            if (node.Value.Equals(value))
            {
                break;
            }

            node = node.Next;
        }
        return node;
    }

    public void Add(T item)
    {
        var newNode = new Node<T>(item);
        if (firstNode is null)
        {
            firstNode = newNode;
            lastNode = newNode;
            _count++;
            return;
        }
        lastNode.Next = newNode;
        lastNode = newNode;
        _count++;
    }

    public void Clear()
    {
        firstNode.Next = null;
    }

    public bool Contains(T item)
    {
        var isContained = false;
        var current = firstNode;
        foreach (var i in ..Count)
        {
            isContained = current.Value.Equals(item);
            if (isContained)
            {
                break;
            }
        }

        return isContained;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        if (!Contains(item))
        {
            return false;
        }
        var index = IndexOf(item);
        RemoveAt(index);
        return true;
    }

    public int Count
    {
        get => _count; 
    }
    public bool IsReadOnly { get; }
    public int IndexOf(T item)
    {
        var node = firstNode;
        var index = -1;
        foreach (var i in ..Count)
        {
            if (!node.Value.Equals(item))
            {
                node = node.Next;
                continue;
            }

            index = i;
            break;
        }

        return index;
    }

    public void Insert(int index, T item)
    {
        var newNode = new Node<T>(item);

        if (index == Count - 1)
        {
            lastNode.Next = newNode;
            lastNode = newNode;
            return;
        }
        var nodeBefore = GetNodeAt(index - 1);
        var nodeAfter = nodeBefore.Next.Next;
        nodeBefore.Next = newNode;
        newNode.Next = nodeAfter;
        _count++;
    }

    public void RemoveAt(int index)
    {
        if (Count - 1 > index && index > 0)
        {
            var node = GetNodeAt(index-1);
            node.Next = node.Next.Next;
            _count--;
            return;
        }

        if (Count - 1 == index)
        {
            if (Count < 1)
            {
                Clear();
                return;
            }
            lastNode = GetNodeAt(Count - 2);
            _count--;
            return;
        }
        firstNode = firstNode.Next;
        _count--;
    }

    public T this[int index]
    {
        get
        {
            return GetNodeAt(index).Value;
        }
        set
        {
            GetNodeAt(index).Value = value;
        }
    }

    public SingleLinkedList<T> Reversed()
    {
        var reversedList = new SingleLinkedList<T>();
        foreach (var i in ..(Count - 1))
        {
            reversedList.Add(this[(Count - i) - 1]);
        }

        return reversedList;
    }
}
