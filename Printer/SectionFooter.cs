namespace cs_oppgave_03;

public class SectionFooter
{
    public void Print(string result)
    {
        Console.Write($"{ TextFormat.Border(5) }" +
                      $"{ TextColor.Color.CY_B }" +
                      $"Calculator" +
                      $"{ (char)160 }" +
                      $"{ (char)8801 }" +
                      $"{ (char)8801 }" +
                      $"{ (char)160 }" +
                      $"{ TextColor.Color.RS }" +
                      $"{ TextColor.Color.RD }" +
                      $"{ result }" +
                      $"{ TextColor.Color.RS }");
        
        Console.WriteLine();

        Console.WriteLine($"{ TextFormat.Border(3) }" +
                          $"{ TextColor.Color.CY_B }" +
                          $"{ TextColor.Color.RS }");
    }
}