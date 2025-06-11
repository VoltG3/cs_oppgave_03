using System.Text;

namespace cs_oppgave_03;

public class Content
{
    private static string FormatSequence(
        IReadOnlyList<string> tokens,
        int opIndex,                    // this step operator index
        string yellow, string blue, string reset)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < tokens.Count; i++)
        {
            // should this token highlightes?
            bool highlight = i == opIndex || i == opIndex - 1 || i == opIndex + 1;
            string color   = highlight ? yellow : blue;

            sb.Append(color).Append(tokens[i]).Append(reset);

            // need space after tokens?
            bool nextIsRightParen = (i + 1 < tokens.Count) && tokens[i + 1] == ")";
            bool thisIsLeftParen  = tokens[i] == "(";

            if (!thisIsLeftParen && !nextIsRightParen)
                sb.Append(' ');
        }

        return sb.ToString();
    }

    public void Print(
        IReadOnlyList<List<string>> sequences,
        IReadOnlyList<string> steps,
        IReadOnlyList<string> brackets)
    {
        for (int idx = 0; idx < steps.Count; idx++)
        {
            
            int justify = 8;
            string bracketInfo = "";

            if (idx < brackets.Count &&
                int.TryParse(brackets[idx], out int bCount) && bCount > 0)
            {
                justify = 5;
                bracketInfo = $"{TextColor.Color.YL_B}({bCount}){TextColor.Color.RS}";
            }

            Console.Write($"{ TextFormat.Border(justify) }" +
                          $"{ bracketInfo }" +
                          $"{ (char)160 }" +  
                          $"{ TextColor.Color.CY_B }" +
                          $"Step" +
                          $"{ (char)160 }" +
                          $"{idx + 1,2}" +
                          $"{ (char)160 }" +
                          $":" +
                          $"{ (char)160 }" +
                          $"{ TextColor.Color.RS }");
            
            int opIndex = int.Parse(steps[idx]);  
            
            string line = FormatSequence(
                sequences[idx],
                opIndex,
                TextColor.Color.YL_B,
                TextColor.Color.BL_B,
                TextColor.Color.RS);

            Console.WriteLine(line);
        }
    }
} 
