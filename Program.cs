namespace cs_oppgave_03;

class Program
{
    static void Main(string[] args)
    {
        
        string preDefinedUserInput = "12 + 12 - 4 * 3 / 7";
        
        // 12 + 12 - 4 * 3 / 7  :: 5
        // 12 + 12 - 12 / 7     :: 5
        // 12 + 12 - ..   :: 1 :: 1
        //
        //
        //
        
        // ToDo -> readLine userInput
        
        // ToDo -> validation
        
        string[] expressionArray = preDefinedUserInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        // initilize StepsPrinter
        StepsPrinter stepsPrinter = new StepsPrinter();
        stepsPrinter.AddArr(expressionArray);
        
        while (expressionArray.Length > 1)
        {
            // get the next priority operator
            var opIndex = Operator.Index(expressionArray);
            
            Console.WriteLine($"NEXT OPERATOR {opIndex}");
            
            // set the next priority operator, for printer
            stepsPrinter.AddStep(opIndex.ToString());
            
            if (opIndex == -1 || opIndex <= 0 || opIndex >= expressionArray.Length - 1)
                break;
            
            string left = expressionArray[opIndex - 1];
            string op = expressionArray[opIndex];
            string right = expressionArray[opIndex + 1];
                
            // execute part of the expression
            Calculate calc = new Calculate();
            string result = calc.Expression(left, op, right);
                
            // replace the part of the expression with the result
            List<string> tempList = new List<string>();
                
            for (int j = 0; j < expressionArray.Length; j++)
            {
                if (j == opIndex - 1) 
                { 
                    tempList.Add(result); 
                }
                
                if (j != opIndex && j != opIndex + 1 && j != opIndex - 1)
                { 
                    tempList.Add(expressionArray[j]);
                }
            }

            expressionArray = tempList.ToArray();
        }
        
        //
        //
        
        stepsPrinter.PrintAllSteps();
        
        //
        //
        
        // ToDo -> print result, step by step
        
        foreach (string item in expressionArray)
        {
            Console.WriteLine(item);
        }
        
        // ToDo -> TextFormat
    }
}