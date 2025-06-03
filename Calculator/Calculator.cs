namespace  cs_oppgave_03;

public class Calculator : IMultiplication, IDivision, IAddition, ISubtraction
{
    public int Multiply(int a, int b) => a * b;
    public double Multiply(double a, double b) => a * b;
    public int Divide(int a, int b) => a / b;
    public double Divide(double a, double b) => a / b;
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public double Subtract(double a, double b) => a - b;
    
}