namespace cs_oppgave_03;

public interface IMultiplication
{
    /// <summary>
    /// Multiplication Int
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public int Multiply(int a, int b);
    
    /// <summary>
    /// Multiplication Double
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public double Multiply(double a, double b);
}