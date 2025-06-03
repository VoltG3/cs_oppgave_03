namespace cs_oppgave_03;


public interface IDivision
{
    /// <summary>
    /// Division Int
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a - b</returns>
    public int Divide(int a, int b);
    
    /// <summary>
    /// Division Double
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a - b</returns>
    public double Divide(double a, double b);
}