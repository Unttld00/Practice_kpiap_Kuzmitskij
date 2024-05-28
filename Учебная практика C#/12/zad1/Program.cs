using System;

public delegate double CalcFigure(double r);

class Program
{
    static void Main(string[] args)
    {
        CalcFigure CF;

        CF = Get_Length;
        Console.WriteLine("Длина окружности: " + CF(5));

        CF = Get_Area;
        Console.WriteLine("Площадь круга: " + CF(5));

        CF = Get_Volume;
        Console.WriteLine("Объем шара: " + CF(5));

        Console.ReadKey();
    }

    public static double Get_Length(double r)
    {
        return 2 * Math.PI * r;
    }

    public static double Get_Area(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }

    public static double Get_Volume(double r)
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
    }
}

