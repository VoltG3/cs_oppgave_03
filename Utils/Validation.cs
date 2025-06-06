namespace cs_oppgave_03;

using System;
using System.Globalization;

public class Validation
{
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
    
    public static bool UserInput(string userString)
    {
        string[] token = userString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var invalidIndices = new List<int>();
        bool isTokenCorrupted = false;
        
        for (int i = 0; i < token.Length; i++)
        {
            string tokenItem = token[i];
            
            bool isInt = IsInteger(tokenItem);
            bool isDouble = IsDouble(tokenItem);
            bool isOperator = IsOperator(tokenItem);
            
            if (!(isInt || isDouble || isOperator))
            {
                invalidIndices.Add(i);
                isTokenCorrupted = true;
            }
        }

        if (isTokenCorrupted)
        {
            var invalid = new HashSet<int>(invalidIndices);
            
            TextFormat.Space(1);
            Console.WriteLine($"{ TextFormat.Border(3)}{ TextColor.Color.RD_B }Invalid input{ TextColor.Color.RS }");
            
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