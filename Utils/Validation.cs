namespace cs_oppgave_03;

public class Validation
{
    public static bool IsInteger(string item)
    {
        return int.TryParse(item, out _);
    }
    
    public static bool IsDouble(string item)
    {
        return double.TryParse(item, out _);
    }

    public static bool IsOperator(string item)
    {
        switch (item)
        {
            case "*":
            case "/":
            case "+":
            case "-":
                return true;
            default:
                return false;
        }
    }
}