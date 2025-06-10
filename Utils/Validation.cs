using System.Globalization;
using System.Text.RegularExpressions;

namespace cs_oppgave_03;

public class Validation
{
    public static int HasParenthesesSets(string[] tokens)
    {
        var countOfParenthesisSets = 0;
        var openParentheses = 0;
    
        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] == "(")
            {
                openParentheses++;
            }
            else if (tokens[i] == ")")
            {
                if (openParentheses > 0)
                {
                    countOfParenthesisSets++;
                    openParentheses--;
                }
            }
        }
    
        return countOfParenthesisSets;
    }
    
    public static string ValidateWithSpaces(string input)
    {
        string output = Regex.Replace(input, @"([+\-*/()])", " $1 ");
        return Regex.Replace(output, @"\s+", " ").Trim();
    }
    
    public static bool IsInteger(string item)
    {
        return int.TryParse(item, out _);
    }
    
    public static bool IsDouble(string item)
    {
        return double.TryParse(item, NumberStyles.Float, CultureInfo.InvariantCulture, out _);
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

    public static bool IsParentheses(string item)
    {
        switch (item)
        {
            case "(":
            case ")":
                return true;
            default:
                return false;
        }
    }
    
    public static bool UserInput(string rawInput)
    {
        string userString = ValidateWithSpaces(rawInput);
        string[] token = userString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var invalid = new HashSet<int>();          // set of token indices to be colored red
        var openParenStack = new Stack<int>();     // stores indices of open parentheses tokens

        // Iterate through each token
        for (int i = 0; i < token.Length; i++)
        {
            string tk = token[i];
        
            bool isValid = IsInteger(tk) || IsDouble(tk) || IsOperator(tk) || IsParentheses(tk);
            if (!isValid) invalid.Add(i);

            // specially scans each character for bracket balance
            foreach (char ch in tk)
            {
                if (ch == '(')
                { 
                    openParenStack.Push(i);        // open parenthesis – notes in which token
                }
                
                else if (ch == ')')
                {
                    if (openParenStack.Count > 0)
                        openParenStack.Pop();      // closes the last one opened
                    else
                        invalid.Add(i);            // superfluous closing
                }
            }
        }

        // if there are any unopened parentheses, mark their token.
        while (openParenStack.Count > 0)
            invalid.Add(openParenStack.Pop());
        
        if (invalid.Count > 0)
        {
            TextFormat.Space(1);
            Console.WriteLine($"{ TextFormat.Border(3) }{ TextColor.Color.RD_B }Invalid input{ TextColor.Color.RS }");

            Console.Write($"{ TextFormat.Border(3) }");
            for (int i = 0; i < token.Length; i++)
            {
                var color = invalid.Contains(i) ? TextColor.Color.RD_B : TextColor.Color.BL_B;
                Console.Write($"{ color }{ token[i] }{ TextColor.Color.RS } ");
            }
            TextFormat.Space(1);
            
            return true;           
        }
        
        return false;              
    }
}