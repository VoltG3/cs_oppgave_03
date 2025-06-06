namespace cs_oppgave_03;

class Program
{
    static void Main(string[] args)
    {
        
        string preDefinedUserInput = "12.965 + 12.345 - 4.00 * 3 / 7 - 4 + 12 * 7 / 10 - 5 + 6 + 10";
        string userInput = "10.78r6 - 15.2334 - g - 45.0412";
        
        // ToDo -> readLine userInput
        // ToDo -> random expression
        // ToDo -> validation
        // ToDo -> brackets
        // ToDo -> refactoring
        // ToDo -> recursive
        
        Calculator.Calc(preDefinedUserInput);

       // if (Validation.UserInput(userInput)) return;
        
        //Calculator.Calc(userInput);

        
        
        string tmp = "12.3424 - 5.543 + 0.01 + 13.00";
        string[] tmp2 = tmp.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < tmp2.Length; i++)
        {
            Console.Write($"Checking: {tmp2[i]}");
            if (Validation.IsDouble(tmp2[i]))
            {
                tmp2[i] = Formatting.IsUnformattedDouble(tmp2[i]);
            }
        }

        foreach (string item in tmp2)
        {
            Console.WriteLine(item + " ");
        }
    }
}