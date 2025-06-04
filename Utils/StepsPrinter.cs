namespace cs_oppgave_03;

public class StepsPrinter
{
    // Fields
    public List<List<string>>? ExpressionsLists { get; set; } = new List<List<string>>();
    public List<string>? expressionsSteps{ get; set; } = new List<string>();

    // Constructor
    public void AddList(List<string> list)
    {
        ExpressionsLists?.Add(list);
    }
    
    public void AddStep(string step)
    {
        expressionsSteps?.Add(step);
    }
    
    // Methods & Functions
    public void PrintAllExpressionLists()
    {
        if (ExpressionsLists == null || ExpressionsLists.Count == 0)
        {
            Console.WriteLine("Nav neviena izteiksmes soļa.");
            return;
        }

        int stepNumber = 1;
        foreach (var list in ExpressionsLists)
        {
            Console.Write($"Step {stepNumber++}: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    public void PrintAllSteps()
    {
        /*
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
                    
                    //arr.RemoveAt(int.Parse(targetIndex));
                }
                else
                {
                    Console.Write($"{ expressionsArray[i] }");
                }
            }
            Console.WriteLine("\n");
        } */
    }
    
    // Destructor
    ~StepsPrinter()
    {
        ExpressionsLists = null;
        expressionsSteps = null;
    }
}