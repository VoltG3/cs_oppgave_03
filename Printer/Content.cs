namespace cs_oppgave_03;

public class Content
{
    public void Print(IReadOnlyList<List<string>> sequences, IReadOnlyList<string> steps, IReadOnlyList<string> brackets)
    {
        //Debug.DebuggArray(brackets.ToArray());

        //var temp = brackets[1];
        
        for (int index = 0; index < steps.Count; index++)
        {
            string bracketCount = "";
            int justifyBorder = 8;

            // checking if there is any data in the index
            if (index < brackets.Count && int.TryParse(brackets[index], out int parsedCount) && parsedCount > 0)
            {
                justifyBorder = 5;
                bracketCount = $"{ TextColor.Color.YL_B }({parsedCount}){ TextColor.Color.RS }";
            }
            
            Console.Write($"{ TextFormat.Border(justifyBorder) }" +
                          $"{ bracketCount }" +
                          $"{ (char)160 }" +
                          $"{ TextColor.Color.CY_B }" +
                          $"Step" +
                          $"{ (char)160 }" +
                          //$"{ TextColor.Color.YL_B }" +
                          $"{index + 1,2}" +
                          //$"{ TextColor.Color.RS }" +
                          $"{ (char)160 }" +
                          $":" +
                          $"{ TextColor.Color.RS } ");

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