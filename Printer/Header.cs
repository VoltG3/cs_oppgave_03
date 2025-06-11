using System.Text;

namespace cs_oppgave_03;

public class Header
{
    private static string FormatExpressionCompact(IReadOnlyList<string> tokens)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < tokens.Count; i++)
        {
            string current = tokens[i];

            // Pievieno tokenu
            sb.Append(current);

            // Vai jāpieliek atstarpe?
            bool thisIsLeftParen = current == "(";
            bool nextIsRightParen = (i + 1 < tokens.Count) && tokens[i + 1] == ")";

            if (!thisIsLeftParen && !nextIsRightParen && i + 1 < tokens.Count)
                sb.Append(' ');
        }

        return sb.ToString();
    }
    
    public void Print(string totalLength, List<string> expression)
    {
        Console.WriteLine($"{ TextFormat.Border(3) }" +
                          $"{ TextColor.Color.CY_B }" +
                          $"{ TextFormat.HorizontalLine(int.Parse(totalLength)) }" +
                          $"{ TextColor.Color.RS }");

        Console.Write($"{ TextFormat.Border(5) }" +
                      $"{ TextColor.Color.CY_B }" +
                      $"Expression" +
                      $"{ (char)160 }" +
                      $"{ (char)8801 }" +
                      $"{ (char)8801 }" +
                      $"{ TextColor.Color.RS } ");

        string compact = FormatExpressionCompact(expression);
        Console.WriteLine($"{ TextColor.Color.RD }{compact}{ TextColor.Color.RS }");
        
    }
}