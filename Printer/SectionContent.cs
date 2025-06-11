namespace cs_oppgave_03;

public class SectionContent
{
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
                bracketInfo = $"{ TextColor.Color.YL_B }" +
                              $"{ bCount }" +
                              $"()" +
                              $"{ TextColor.Color.RS }";
            }

            Console.Write($"{ TextFormat.Border(justify) }" +
                          $"{ bracketInfo }" +
                          $"{ (char)160 }" +  
                          $"{ TextColor.Color.CY_B }" +
                          $"Step" +
                          $"{ (char)160 }" +
                          $"{ idx + 1,2 }" +
                          $"{ (char)160 }" +
                          $":" +
                          $"{ (char)160 }" +
                          $"{ TextColor.Color.RS }");
            
            int opIndex = int.Parse(steps[idx]);  
            
            string line = PrinterHelper.FormatExpressionCompactForSectionContent(
                sequences[idx],
                opIndex,
                TextColor.Color.YL_B,
                TextColor.Color.BL_B,
                TextColor.Color.RS);

            Console.WriteLine(line);
        }
    }
} 