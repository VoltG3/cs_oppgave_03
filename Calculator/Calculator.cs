using System.Linq.Expressions;

namespace  cs_oppgave_03;

public class Calculate : IMultiplication, IDivision, IAddition, ISubtraction
{
    public int Multiply(int a, int b) => a * b;
    public double Multiply(double a, double b) => a * b;
    public int Divide(int a, int b) => a / b;
    public double Divide(double a, double b) => a / b;
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public double Subtract(double a, double b) => a - b;

    public string Expression(string firstOperand, string targetOperator, string secondOperand)
    {
        bool isFirstInt = int.TryParse(firstOperand, out var a);
        bool isSecondInt = int.TryParse(secondOperand, out var b);
        
        if (isFirstInt && isSecondInt)
        {
            var resultInteger = targetOperator switch
            {
                "*" => Multiply(a, b),
                "/" => Divide(a, b),
                "+" => Add(a, b),
                "-" => Subtract(a, b),
                _ => throw new Exception("Invalid operator")
            };
            
            return resultInteger.ToString();
        }
        
        double doubleA = double.Parse(firstOperand);
        double doubleB = double.Parse(secondOperand);

        var resultDouble = targetOperator switch
        {
            "*" => Multiply(doubleA, doubleB),
            "/" => Divide(doubleA, doubleB),
            "+" => Add(doubleA, doubleB),
            "-" => Subtract(doubleA, doubleB),
            _ => throw new Exception("Invalid operator")
        };
        
        return resultDouble.ToString();
    }
}