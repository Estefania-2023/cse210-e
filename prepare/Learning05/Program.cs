using System;

class Program
{
    static void Main(string[] args)
    {
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Because it does not make sense to define a default body for this method in the
    // base class, rather than make a "virtual" function here like this:
    //
    // public virtual double GetArea()
    // {
    //     return 0;
    // }
    //
    // We can instead declare the function as an "abstract" function. That means
    // that it is an empty virtual function that must be implemented or "filled in" by
    // any class that inherits from Shape. Then, any class that has an abstract method
    // must also be declared to be abstract.
    public abstract double GetArea();
}

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _length * _width;
    }
}

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _side * _side;
    }
}

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}