namespace cs_oppgave_03;

public class Helper
{
    public static string[] PrepareExpression(string expression)
    {
        var array = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return Formatting.IsUnformattedDoubleInArray(array);
    }
}