namespace cs_oppgave_03;

public class Header
{
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

        foreach (var item in expression)
            Console.Write($"{ TextColor.Color.RD }{item}{ TextColor.Color.RS } ");

        Console.WriteLine();
    }
}