namespace Algorythms.Core;

public static class Extensions
{
    public static IntEnumerator GetEnumerator(this Range range)
    {
        return new IntEnumerator(range);
    }
}

public ref struct IntEnumerator
{
    private int _current;
    private int _end;
    public IntEnumerator(Range range)
    {
        _end = range.End.Value;
        _current = range.Start.Value - 1;
    }

    public int Current => _current;

    public bool MoveNext()
    {
        _current++;
        return _current <= _end;
    }
}