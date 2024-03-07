namespace Task3;

public class Gauge
{
    public int value {get;set;}
    public Gauge()
    {}

    public void Enhance()
    {
        if (value < 4)
        {
            value++;
        }
    }

    public void Decrease()
    {
        if (value > 1)
        {
            value--;
        }
    }

    public bool Full()
    {
        // if (value == 5)
        // {
        //     return true;
        // }else{
        //     return false;
        // }
        return value == 5;
    }
}
