namespace cs_oppgave_03;

public class Calculator
{
    public static void Calc(string expressionString)
    {
        // Initialize
        string[] expressionArray = expressionString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                 expressionArray = Formatting.IsUnformattedDoubleInArray(expressionArray);
        
        Printer printer = new Printer();
        
        // Line ...
        int totalLength = expressionString.Length;
            totalLength += 17;
            printer.AddTotalLength(totalLength.ToString());
        
        printer.AddList(expressionArray.ToList());
        
        while (expressionArray.Length > 1)
        {
            // get the next priority operator
            var opIndex = Operator.Index(expressionArray);
            
            // set the next priority operator, for printer
            printer.AddStep(opIndex.ToString());
            
            if (opIndex == -1 || opIndex <= 0 || opIndex >= expressionArray.Length - 1)
                break;
            
            string left = expressionArray[opIndex - 1];
            string op = expressionArray[opIndex];
            string right = expressionArray[opIndex + 1];
                
            // execute part of the expression
            //Calculate calc = new Calculate();
            string result = Expression.Calc(left, op, right);
            
            //result = Formatting.IsUnformattedDouble(result);
            
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
            
            // set the new expressionArray
            expressionArray = tempList.ToArray();
            
            //Console.WriteLine($"Result { result }");
            
            // set the new expressionArray to printer
            printer.AddList(expressionArray.ToList());
            
        }
        
        printer.CalculatingSequence();
    }
}