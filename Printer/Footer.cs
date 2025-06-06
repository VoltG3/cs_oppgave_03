namespace cs_oppgave_03;

public class Footer
{
    public void Print(string totalLength, string result)
    {
        Console.Write($"{TextFormat.Border(5)}{TextColor.Color.CY_B}Calculator :" +
                      $"{TextColor.Color.RS} {TextColor.Color.RD}{result}{TextColor.Color.RS}");
        Console.WriteLine();

        Console.WriteLine($"{TextFormat.Border(3)}{TextColor.Color.CY_B}" +
                          $"{TextFormat.HorizontalLine(int.Parse(totalLength))}" +
                          $"{TextColor.Color.RS}");
    }
}