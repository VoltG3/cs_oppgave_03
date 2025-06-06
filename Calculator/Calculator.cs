namespace cs_oppgave_03;

public class Calculator
{
    public static void Calc(string expressionString)
    {
        // Initialize
        string[] token = Helper.PrepareExpression(expressionString);
        Printer printer = new Printer();
        
        // Line ...
        int totalLength = expressionString.Length;
            totalLength += 17;
            printer.SetTotalLength(totalLength.ToString());
        
        printer.AddList(token.ToList());
        
        while (token.Length > 1)
        {
            // get the next priority operator
            var opIndex = Operator.Index(token);
            
            // set the next priority operator, for printer
            printer.AddStep(opIndex.ToString());
            
            if (opIndex == -1 || opIndex <= 0 || opIndex >= token.Length - 1)
                break;
            
            string left = token[opIndex - 1];
            string op = token[opIndex];
            string right = token[opIndex + 1];
                
            // execute part of the expression
            string result = Expression.Calc(left, op, right);
                 //result = Formatting.IsUnformattedDouble(result);
            
            // replace the part of the expression with the result
            List<string> tempList = new List<string>();
                
            for (int j = 0; j < token.Length; j++)
            {
                if (j == opIndex - 1) 
                { 
                    tempList.Add(result); 
                }
                
                if (j != opIndex && j != opIndex + 1 && j != opIndex - 1)
                { 
                    tempList.Add(token[j]);
                }
            }
            
            // set the new expressionArray
            token = tempList.ToArray();
            
            //Console.WriteLine($"Result { result }");
            
            // set the new expressionArray to printer
            printer.AddList(token.ToList());
            
        }
        
        printer.CalculatingSequence();
    }
}