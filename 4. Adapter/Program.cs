using System;

interface IShape
{
    double GetArea();
}

class Square
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double GetSide()
    {
        return side;
    }

    public void SetSide(double side)
    {
        this.side = side;
    }

    public double CalculateArea()
    {
        return side * side;
    }
}

class SquareAdapter : IShape
{
    private Square square;

    public SquareAdapter(Square square)
    {
        this.square = square;
    }

    public double GetArea()
    {
        return square.CalculateArea();
    }
}

class Program
{
    static void Main()
    {
        Square square = new Square(5.0);
        IShape shape = new SquareAdapter(square);

        Console.WriteLine("Area of the square: " + shape.GetArea());
    }
}
