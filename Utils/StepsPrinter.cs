namespace cs_oppgave_03;

public class StepsPrinter
{
    // Fields
    public string[]? expressionsArray { get; set; } = new string[0];
    public List<string>? expressionsSteps{ get; set; } = new List<string>();

    // Constructor
    public void AddArr(string[] arr)
    {
        expressionsArray = arr;
    }
    
    public void AddStep(string step)
    {
        expressionsSteps?.Add(step);
    }
    
    // Methods & Functions
    public void PrintAllSteps()
    {
        List<string> arr = expressionsArray.ToList();
        
        foreach (string targetIndex in expressionsSteps)
        {
            Console.Write($"Step ");
            for (int i = 0; i < arr.Count; i++)
            {
                if (i - 1 == int.Parse(targetIndex) || i == int.Parse(targetIndex) || i + 1 == int.Parse(targetIndex))
                {
                    Console.Write(
                        $"{ TextColor.Color.CY_B }" +
                        $"{ expressionsArray[i] }" +
                        $"{ TextColor.Color.RS }");
                }
                else
                {
                    Console.Write($"{ expressionsArray[i] }");
                }
                
                
            }
            Console.WriteLine("\n");
        }
    }
    
    // Destructor
    ~StepsPrinter()
    {
        expressionsArray = null;
        expressionsSteps = null;
    }
}