namespace zad1
{
    public interface Iy
{
    double F0(int w);
    double F1(int w);
}

public interface Iz
{
    double F0(int w);
    double F1(int w);
}

class Program : Iy, Iz
{
    public double F0(int w)
    {
        return w+5;
    }

    public double F1(int w)
    {
        return Math.Pow(w, 3);
    }

    public double IyF0(int w)
    {
        return ((Iy)this).F0(w);
    }






    public double IyF1(int w)
    {
        return ((Iy)this).F1(w);
    }

    public double IzF0(int w)
    {
        return ((Iz)this).F0(w);
    }

    public double IzF1(int w)
    {
        return ((Iz)this).F1(w);
    }

    static void Main()
    {
        Program program = new Program();
        int w = 1;

        Console.WriteLine("F0 from Iy: " + program.IyF0(w));
        Console.WriteLine("F1 from Iy: " + program.IyF1(w));
        Console.WriteLine("F0 from Iz: " + program.IzF0(w));
        Console.WriteLine("F1 from Iz: " + program.IzF1(w));
    }
}
}
