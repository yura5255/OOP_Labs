using System;

class QuadraticEquation
{
    public double b2, b1, b0;

    public QuadraticEquation(double b2, double b1, double b0)
    {
        this.b2 = b2;
        this.b1 = b1;
        this.b0 = b0;
    }

    public void DisplayCoefficients()
    {
        Console.WriteLine($"Coefficients: b2 = {b2}, b1 = {b1}, b0 = {b0}");
    }

    public bool IsSolution(double number)
    {
        double result = b2 * Math.Pow(number, 2) + b1 * number + b0;
        return result == 0;
    }

    public void FindRoots()
    {
        // Реалізація пошуку коренів квадратного рівняння
        // ...
    }
}

class CubicEquation : QuadraticEquation
{
    private double b3;

    public CubicEquation(double b3, double b2, double b1, double b0) : base(b2, b1, b0)
    {
        this.b3 = b3;
    }

    public new void DisplayCoefficients()
    {
        Console.WriteLine($"Coefficients: b3 = {b3}, b2 = {base.b2}, b1 = {base.b1}, b0 = {base.b0}");
    }

    public bool IsSolutionCubic(double number)
    {
        double result = b3 * Math.Pow(number, 3) + Convert.ToDouble(base.IsSolution(number));
        return result == 0;
    }

}

class Program
{
    static void Main()
    {
        // Створення об'єкта класу "Квадратне рівняння"
        QuadraticEquation quadraticEquation = new QuadraticEquation(1, -3, 2);

        // Виклик методів
        quadraticEquation.DisplayCoefficients();
        double numberToCheck = 1;
        Console.WriteLine($"Is {numberToCheck} a solution? {quadraticEquation.IsSolution(numberToCheck)}");
        quadraticEquation.FindRoots();

        // Створення об'єкта класу "Кубічне рівняння"
        CubicEquation cubicEquation = new CubicEquation(1, -3, 3, -1);

        // Виклик методів
        cubicEquation.DisplayCoefficients();
        double numberToCheckCubic = 1;
        Console.WriteLine($"Is {numberToCheckCubic} a solution? {cubicEquation.IsSolutionCubic(numberToCheckCubic)}");
        cubicEquation.FindRoots();  // Виклик успадкованого методу
    }
}
