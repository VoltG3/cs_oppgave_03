namespace cs_oppgave_03;

public class Expression
{
    public static string Calc(string firstOperand, string targetOperator, string secondOperand)
    {
        var calc = new Formula();
        
        bool isFirstInt = int.TryParse(firstOperand, out var a);
        bool isSecondInt = int.TryParse(secondOperand, out var b);
        
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
            
            //return resultInteger.ToString("0.00");
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
        
        //return resultDouble.ToString("0.00");
        return resultDouble.ToString();
    }
}