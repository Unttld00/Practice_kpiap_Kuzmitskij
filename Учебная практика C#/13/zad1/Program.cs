delegate double MathOperation(double x);


class Program
{
    static void Main(string[] args)
    {
        
        static double Square(double x) => x * x;
static double Cube(double x) => x * x * x;
        static double Logarithm(double x) => Math.Log(x);
        
        MathOperation mathOperation1 = Square;
        MathOperation mathOperation2 = Cube;
        MathOperation mathOperation3 = Logarithm;

       
        double result1 = mathOperation1(5);
        Console.WriteLine($"Результат функции Square: {result1}");

        double result2 = mathOperation2(5);
        Console.WriteLine($"Результат функции Cube: {result2}");

        double result3 = mathOperation3(5);
        Console.WriteLine($"Результат функции Logarithm: {result3}");
    }
}

