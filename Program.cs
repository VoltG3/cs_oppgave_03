namespace cs_oppgave_03;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string preDefinedUserInput = "100 + 80 - 30 + 13.77 + 0.33 * 13 / 10 * (((12 + 4 * 7)+(6-6)) * (12 + 4 * 7))";
        
        // ToDo -> readLine userInput
        // ToDo -> random expression
        // ToDo -> validation
        // ToDo -> brackets
        // ToDo -> refactoring
        // ToDo -> recursive
        
        Calculator.Calc(preDefinedUserInput);
        
        Console.Write($"{ TextFormat.Border(4)}{ TextColor.Color.CY_B } User Input: ");
        string userInput = Console.ReadLine();
        Console.Write($"{ TextColor.Color.RS }");
        
        //string userInput = "10.78656 - (15.2334 + 36.34543) + 45.0412 * 33 / 2";
        string formattedUserInput = Validation.ValidateWithSpaces(userInput);
        
        if (Validation.UserInput(formattedUserInput)) return;
        
        Calculator.Calc(formattedUserInput);
    }
}