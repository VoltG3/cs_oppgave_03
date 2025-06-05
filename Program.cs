namespace cs_oppgave_03;

class Program
{
    static void Main(string[] args)
    {
        
        string preDefinedUserInput = "12 + 12 - 4 * 3 / 7 - 4 + 12 * 7 / 10 - 5 + 6 + 10";
        string userInput = "10.78r6 - 15.2334 - g - 45.0412";
        
        // ToDo -> readLine userInput
        // ToDo -> random expression
        // ToDo -> validation
        // ToDo -> brackets
        // ToDo -> refactoring
        
        Calculator.Calc(preDefinedUserInput);

        if (UserInput.IsInvalid(userInput)) return;
        
        Calculator.Calc(userInput);
    }
}