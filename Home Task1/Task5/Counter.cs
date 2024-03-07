namespace Task5;

public class Counter
{
    int _value;

    public Counter(int value)
    {
        _value = value;
    }

    public int Decrement()
    {
        if (_value > 0 )
        {
            _value--;
        }
        return _value;
    }

    public int Reset()
    {
        _value = 0;
        return _value;
    }

    public int PrintValue()
    {
        return _value;
    }
}

