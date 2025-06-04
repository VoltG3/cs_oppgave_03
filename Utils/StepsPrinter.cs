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
        foreach (string item in expressionsSteps)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"ArrLength{expressionsArray.Length}");
    }
    
    // Destructor
    ~StepsPrinter()
    {
        expressionsArray = null;
        expressionsSteps = null;
    }
}