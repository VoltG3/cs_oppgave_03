namespace cs_oppgave_03;

public class Helper
{
    public static string[] PrepareExpression(string expression)
    {
        var array = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return Formatting.IsUnformattedDoubleInArray(array);
    }

    public static int CalculatePaddingLength(string expression)
    {
        const int basePadding = 17;
        return expression.Length + basePadding;
    }
    
    public static bool IsInvalidOperatorIndex(int index, int length)
    {
        return index <= 0 || index >= length;
    }
    
    public static List<string> ReplaceWithResult(string[] array, int opIndex, string result)
    {
        var list = new List<string>();

        for (int i = 0; i < array.Length; i++)
        {
            if (i == opIndex - 1)
                list.Add(result);
            else if (i != opIndex && i != opIndex + 1)
                list.Add(array[i]);
        }

        return list;
    }
    
    public static (int startIndex, int endIndex) FindDeepestParenthesesIndices(string[] str)
    {
        int maxDepth = -1;
        int currentDepth = 0;
        int deepestStartIndex = -1;
        int deepestEndIndex = -1;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == "(")
            {
                currentDepth++;
                if (currentDepth > maxDepth)
                {
                    maxDepth = currentDepth;
                    deepestStartIndex = i;
                    deepestEndIndex = -1; // Reset end index when we find new deeper opening
                }
            }
            else if (str[i] == ")")
            {
                if (currentDepth == maxDepth && deepestEndIndex == -1)
                {
                    deepestEndIndex = i;
                }
                currentDepth--;
            }
        }

        return (deepestStartIndex, deepestEndIndex);
    }
}