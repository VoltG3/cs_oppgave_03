using System.Text.RegularExpressions;

namespace cs_oppgave_03;

public class Helper
{
    public static string[] PrepareExpression(string expression)
    {
        var matches = Regex.Matches(expression, @"(?<!\d|\))-\d+(\.\d+)?|\d+(\.\d+)?|[+*/()\-]");

        //return matches.Select(m => m.Value).ToArray();
       // var array = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return Formatting.IsUnformattedDoubleInArray(matches.Select(m => m.Value).ToArray());
    }

    /*
    public static string PrepareExpressionForPrinter(string expression)
    {
        // remove space before and after brackets
        string result = Regex.Replace(expression, @"\(\s+", "("); // remove space after (
        result = Regex.Replace(result, @"\s+\)", ")");            // remove space before )
    
        // remove space between brackets and numbers
        result = Regex.Replace(result, @"\s*\(\s*", "(");         // remove all spaces beforea nd after (
        result = Regex.Replace(result, @"\s*\)\s*", ")");         // remove all spaces beforea nd after )

        return result;
    }
   */
   
    public static string[] PrepareExpressionForPrinter(string[] tokens)
    {
        var result = new List<string>();
        string prefix = "";          
                                   
        foreach (var t in tokens)
        {
            if (t == "(")
            {
                prefix += "(";        
                continue;
            }

            if (t == ")")
            {
                if (result.Count > 0) 
                    result[^1] += ")";

                continue;
            }

            
            string token = prefix.Length > 0 ? prefix + t : t;
            prefix = "";              
            result.Add(token);
        }

       
        if (prefix.Length > 0)
            result.Add(prefix);

        return result.ToArray();
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

    public static (int startIndex, int endIndex) FindDeepestParenthesesIndices(string[] tokens)
    {
        int currentDepth = 0;
        var stack = new Stack<(int index, int depth)>();
        var matchedPairs = new List<(int start, int end, int depth)>();

        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] == "(")
            {
                currentDepth++;
                stack.Push((i, currentDepth));
            }
            else if (tokens[i] == ")")
            {
                if (stack.Count > 0)
                {
                    var (start, depth) = stack.Pop();
                    matchedPairs.Add((start, i, depth));
                    currentDepth--;
                }
            }
        }

        if (matchedPairs.Count == 0) return (-1, -1);

        // Atrodam dziļāko pāri
        var deepest = matchedPairs.OrderByDescending(p => p.depth).First();
        return (deepest.start, deepest.end);
    }
}