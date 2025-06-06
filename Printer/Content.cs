namespace cs_oppgave_03;

public class Content
{
    public void Print(IReadOnlyList<List<string>> sequences, IReadOnlyList<string> steps)
    {
        for (int index = 0; index < steps.Count; index++)
        {
            Console.Write($"{TextFormat.Border(8)}{TextColor.Color.CY_B}" +
                          $"Step {index + 1,2} :{TextColor.Color.RS} ");

            for (int i = 0; i < sequences[index].Count; i++)
            {
                int left  = int.Parse(steps[index]);
                int op    = int.Parse(steps[index]);
                int right = int.Parse(steps[index]);

                bool highlight = i - 1 == left || i == op || i + 1 == right;
                var color = highlight ? TextColor.Color.YL_B : TextColor.Color.BL_B;

                Console.Write($"{color}{sequences[index][i]}{TextColor.Color.RS} ");
            }
            Console.WriteLine();
        }
    } 
}