
using System;

class Triangle
{
    private double side1;
    private double side2;
    private double side3;

    public double Side1()
    {
        return side1;
    }

    public double Side2()
    {
        return side2;
    }

    public double Side3()
    {
        return side3;
    }

    public void GetTriangle(double a, double b, double c)
    {
        side1 = a;
        side2 = b;
        side3 = c;
    }

    public double GetPerimetr()
    {
        double Perimetr = side1 + side2 + side3;
        return Perimetr;
    }

    public double GetSquare()
    {
        double P = GetPerimetr() / 2;
        double Square = Math.Sqrt(P * (P - side1) * (P - side2) * (P - side3));
        return Square;
    }

   
}
