namespace  cs_oppgave_03;

public class Expression : IMultiplication, IDivision, IAddition, ISubtraction
{
    public int Multiply(int a, int b) => a * b;
    public double Multiply(double a, double b) => a * b;
    public int Divide(int a, int b) => a / b;
    public double Divide(double a, double b) => a / b;
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public double Subtract(double a, double b) => a - b;
    
    public static string Calc(string firstOperand, string targetOperator, string secondOperand)
    {
        var calc = new Expression();
        
        bool isFirstInt = int.TryParse(firstOperand, out var a);
        bool isSecondInt = int.TryParse(secondOperand, out var b);
        
        // if both are integers
        if (isFirstInt && isSecondInt)
        {
            var resultInteger = targetOperator switch
            {
                "*" => calc.Multiply(a, b),
                "/" => calc.Divide(a, b),
                "+" => calc.Add(a, b),
                "-" => calc.Subtract(a, b),
                _ => throw new Exception("Invalid operator")
            };
            
            return resultInteger.ToString();
        }
        
        double doubleA = double.Parse(firstOperand);
        double doubleB = double.Parse(secondOperand);

        var resultDouble = targetOperator switch
        {
            "*" => calc.Multiply(doubleA, doubleB),
            "/" => calc.Divide(doubleA, doubleB),
            "+" => calc.Add(doubleA, doubleB),
            "-" => calc.Subtract(doubleA, doubleB),
            _ => throw new Exception("Invalid operator")
        };
        
        return resultDouble.ToString();
    }
}