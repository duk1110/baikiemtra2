using System;

interface IShape
{
    double CalculateArea();
}

class Circle : IShape
{
    public double Radius { get; set; }
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        Console.WriteLine("Nhap Radius:");
        circle.Radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Dien tich hinh tron: " + circle.CalculateArea());
        Rectangle rectangle = new Rectangle();
        Console.WriteLine("Nhap Width:");
        rectangle.Width = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap Height:");
        rectangle.Height = double.Parse(Console.ReadLine());
        Console.WriteLine("Dien tich hinh chu nhat:" + rectangle.CalculateArea());
    }
}

