namespace  cs_oppgave_03;

public interface ISubtraction
{
    /// <summary>
    /// Subtraction Int
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a - b</returns>
    int Subtract(int a, int b);
    
    /// <summary>
    /// Subtraction Double
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a - b</returns>
    double Subtract(double a, double b);
}