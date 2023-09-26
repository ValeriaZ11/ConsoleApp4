using System;
/// <summary>
/// Программа для вычисления площади трапеции
/// </summary>
public class Trapezoid
{
    /// <summary>
    /// Константа из формулы площади трапеции
    /// </summary>
    int formula_const = 2;

    #region private
    /// <summary>
    /// Верхнее основание трапеции
    /// </summary>
    private double topBase;
    /// <summary>
    /// Нижнее основание трапеции
    /// </summary>
    private double bottomBase;
    /// <summary>
    /// Высота трапеции
    /// </summary>
    private double height;
    #endregion

    public Trapezoid(double topBase, double bottomBase, double height)
    {

        this.topBase = topBase;

        this.bottomBase = bottomBase;

        this.height = height;
    }

    public double CalculateSquare()
    {
        if (topBase <= 0 | bottomBase <= 0 | height <= 0)
        {
            throw new ArgumentException("Значения должны быть положительными.");
        }

        double halfSumBases = (topBase + bottomBase) / formula_const;
        double square = halfSumBases * height;

        return square;
    }
}

public class TrapezoidCalculation
{
    static void Calculate(int a, int b, int c)
    {
        try
        {
            Trapezoid trapezoid = new Trapezoid(a, b, c);
            double square = trapezoid.CalculateSquare();
            Console.WriteLine($"Площадь трапеции: {square}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
    static void Main(string[] args)
    {
        Calculate(5, 6, 4);
    }
}