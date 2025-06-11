namespace cs_oppgave_03;

public class SectionHeader
{
    public void Print(List<string> expression)
    {
        Console.WriteLine($"{ TextFormat.Border(3) }" +
                          $"{ TextColor.Color.CY_B }" +
                          $"{ TextColor.Color.RS }");

        Console.Write($"{ TextFormat.Border(5) }" +
                      $"{ TextColor.Color.CY_B }" +
                      $"Expression" +
                      $"{ (char)160 }" +
                      $"{ (char)8801 }" +
                      $"{ (char)8801 }" +
                      $"{ TextColor.Color.RS } ");

        string compact = PrinterHelper.FormatExpressionCompactForSectionHeader(expression);
        Console.WriteLine($"{ TextColor.Color.RD }" +
                          $"{ compact }" +
                          $"{ TextColor.Color.RS }");
    }
}