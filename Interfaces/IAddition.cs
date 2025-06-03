namespace cs_oppgave_03;

public interface IAddition
{
    /// <summary>
    /// Additional Int
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a + b</returns>
    int Add(int a, int b);
    
    /// <summary>
    /// Additional Double
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a + b</returns>
    double Add(double a, double b);
}