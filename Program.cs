namespace cs_oppgave_03;

class Program
{
    static void Main(string[] args)
    {
        
        string preDefinedUserInput = "12 + 12 - 4 * 3 / 7";
        
        // ToDo -> readLine userInput
        
        // ToDo -> validation
        
        string[] expressionArray = preDefinedUserInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        for (int i = 0; i < expressionArray.Length; i++)
        {
            // get the next priority operator
            var opIndex = Operator.Index(expressionArray);
            
            // target executable part of expression by priority operator
            if (i == opIndex && i - 1 >= 0 && i + 1 < expressionArray.Length)
            {
                string left = expressionArray[i - 1];
                string op = expressionArray[i];
                string right = expressionArray[i + 1];
                
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
         
        }
        
        // ToDo -> print result, step by step
        
        foreach (string item in expressionArray)
        {
            Console.WriteLine(item);
        }
        
        // ToDo -> TextFormat
    }
}