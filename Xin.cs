using System;

public class Xin
{

    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Address;

    public Xin(string name)
    {
        _name = name;
    }
}