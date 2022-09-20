namespace is_as_Operators;

public class Rectangle:ICalculate
{
    private float _length;
    private float _width;

    public Rectangle(float length, float width)
    {
        _length = length;
        _width = width;
    }

    public double Area()
    {
        return _length * _width;
    }
}