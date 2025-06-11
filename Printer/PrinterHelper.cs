using System.Text;

namespace cs_oppgave_03;

public class PrinterHelper
{
    public static string FormatExpressionCompactForSectionHeader(IReadOnlyList<string> tokens)
    {
        var sb = new StringBuilder();
        
        for (int i = 0; i < tokens.Count; i++)
        {
            string current = tokens[i];
            
            sb.Append(current);
            
            bool thisIsLeftParen = current == "(";
            bool nextIsRightParen = (i + 1 < tokens.Count) && tokens[i + 1] == ")";

            if (!thisIsLeftParen && !nextIsRightParen && i + 1 < tokens.Count)
                sb.Append(' ');
        }

        return sb.ToString();
    }
    
    public static string FormatExpressionCompactForSectionContent(
        IReadOnlyList<string> tokens,
        int opIndex, // this step operator index
        string yellow, string blue, string reset)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < tokens.Count; i++)
        {
            // should this token highlights?
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
}