namespace cs_oppgave_03;

class Program
{
    static void Main(string[] args)
    {
        
        string preDefinedUserInput = "12.965+( ( 10-9.00+4)*(3/7))-4+12*7/10-5+6+10";
        //string userInput = "10.786 - ((15.2334) -45.0412 - f";
        //string formattedUserInput = Validation.ValidateWithSpaces(userInput);
        
        // ToDo -> readLine userInput
        // ToDo -> random expression
        // ToDo -> validation
        // ToDo -> brackets
        // ToDo -> refactoring
        // ToDo -> recursive
        
        Calculator.Calc(preDefinedUserInput);
        
        
        //if (Validation.UserInput(formattedUserInput)) return;
        //Calculator.Calc(formattedUserInput);
        
        
    }
}