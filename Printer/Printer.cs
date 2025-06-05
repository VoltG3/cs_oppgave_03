namespace cs_oppgave_03;

public class Printer
{
    // Fields
    public List<List<string>>? ExpressionSequences { get; set; } = new List<List<string>>();
    public List<string>? operationSteps{ get; set; } = new List<string>();
    public string? TotalLength { get; set; }
    
    // Constructor
    public void AddList(List<string> list)
    {
        ExpressionSequences?.Add(list);
    }
    
    public void AddStep(string step)
    {
        operationSteps?.Add(step);
    }

    public void AddTotalLength(string length)
    {
        TotalLength = length;
    }
    
    // Methods & Functions
    public void CalculatingSequence()
    {
        
        // ##############
        // #   HEADER   #
        // ##############
        
        List<string> tempList = ExpressionSequences[0].ToList();
        
        // draw line by totalCount
        Console.WriteLine($"{ TextFormat.Border(3) }" +
                          $"{ TextColor.Color.CY_B }" +
                          $"{ TextFormat.HorizontalLine(int.Parse(TotalLength)) }" +
                          $"{ TextColor.Color.RS }" +
                          $"");
        
        Console.Write($"{ TextFormat.Border(5)}" +
                      $"{ TextColor.Color.CY_B }" +
                      $"Expression" +
                      $"{ (char)160 }" +
                      $":" +
                      $"{ TextColor.Color.RS }" +
                      $"{ (char)160 }" +
                      $"");
        
        foreach (string item in tempList)
        {
            Console.Write($"" +
                          $"{ TextColor.Color.RD }" +
                          $"{ item }" +
                          $"{ TextColor.Color.RS }" +
                          $"{ (char)160 }" +
                          $"");
        }
        
        Console.WriteLine();
        
        // ###############
        // #   CONTENT   #
        // ###############
        
        for (int index = 0; index < operationSteps.Count; index++)
        {
            Console.Write($"" +
                          $"{ TextFormat.Border(8)}{ TextColor.Color.CY_B }" +
                          $"Step" +
                          $"{ (char)160 }" +
                          $"{ index + 1, 2 }" +
                          $"{ (char)160 }" +
                          $":" +
                          $"{ TextColor.Color.RS }" +
                          $"{ (char)160 }" +
                          $"");
            
            for (int i = 0; i < ExpressionSequences[index].Count; i++)
            {
                int left = int.Parse(operationSteps[index]);
                int op = int.Parse(operationSteps[index]);
                int right = int.Parse(operationSteps[index]);
                
                if (i - 1 == left || i == op || i + 1 == right)
                {
                    Console.Write($"" +
                                  $"{ TextColor.Color.YL_B }" +
                                  $"{ ExpressionSequences[index][i]}{ (char)160 }" +
                                  $"{ TextColor.Color.RS }" +
                                  $"");
                }
                
                else
                {
                    Console.Write($"" +
                                  $"{ TextColor.Color.BL_B }" +
                                  $"{ ExpressionSequences[index][i] }" +
                                  $"{ TextColor.Color.RS }" +
                                  $"{ (char)160 }" +
                                  $"");
                }
            }
            
            Console.WriteLine();
        }
        
        // ##############
        // #   FOOTER   #
        // ##############
        
        string lastListItem = string.Join(" ", ExpressionSequences[^1]);
        
        Console.Write($"{ TextFormat.Border(5)}" +
                      $"{ TextColor.Color.CY_B }" +
                      $"Calculator" +
                      $"{ (char)160 }" +
                      $":" +
                      $"{ TextColor.Color.RS }" +
                      $"{ (char)160 }" +
                      $"{ TextColor.Color.RD }" +
                      $"{ lastListItem }" +
                      $"{ TextColor.Color.RS }" +
                      $"");
        
        Console.WriteLine();
        
        // draw line by totalCount
        Console.WriteLine($"{ TextFormat.Border(3) }" +
                          $"{ TextColor.Color.CY_B }" +
                          $"{ TextFormat.HorizontalLine(int.Parse(TotalLength)) }" +
                          $"{ TextColor.Color.RS }" +
                          $"");
    }
    
    // Destructor
    ~Printer()
    {
        ExpressionSequences = null;
        operationSteps = null;
        TotalLength = null;
    }
}