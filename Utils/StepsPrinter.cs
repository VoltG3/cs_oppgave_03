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
        for (int index = 0; index < expressionsSteps.Count; index++)
        {
            Console.Write($"Step { index + 1 }: ");
            
            for (int i = 0; i < ExpressionsLists[index].Count; i++)
            {
                if (i - 1 == int.Parse(expressionsSteps[index]) || i == int.Parse(expressionsSteps[index]) || i + 1 == int.Parse(expressionsSteps[index]))
                {
                    Console.Write(
                        $"{ TextColor.Color.CY_B }" +
                        $"{ ExpressionsLists[index][i]}{ (char)160 }" +
                        $"{ TextColor.Color.RS }");
                }
                else
                {
                    Console.Write($"{ ExpressionsLists[index][i] }{ (char)160 }");
                }
            }
            
            /*
            foreach (var item in ExpressionsLists[index])
            {
                Console.Write($"{item} ");
            }
            */
            
            Console.WriteLine();
        }
        
        
        /*
        if (expressionsSteps == null || expressionsSteps.Count == 0)
        {
            Console.WriteLine("nav neviena steps");
            return;
        }
        
        if (ExpressionsLists == null || ExpressionsLists.Count == 0)
        {
            Console.WriteLine("Nav neviena izteiksmes soļa.");
            return;
        }
        
        foreach (var targetIndex in expressionsSteps)
        {
            int stepNumber = 1;
            foreach (var list in ExpressionsLists)
            {
                Console.Write($"Step {stepNumber++}: ");
                foreach (var item in list)
                {
                    if (item - 1 == int.Parse(targetIndex) || item == int.Parse(targetIndex) || item + 1 == int.Parse(targetIndex))
                    {
                        Console.Write(
                            $"{ TextColor.Color.CY_B }" +
                            $"{ item + " " }" +
                            $"{ TextColor.Color.RS }");
                    }
                    else
                    {
                        Console.Write(item + " ");
                    }
                }
                Console.WriteLine();
            }
        }*/
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