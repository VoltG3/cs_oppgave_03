namespace cs_oppgave_03;

public class Calculator
{
    public static void Calc(string expressionString)
    {
        string[] tokens = Helper.PrepareExpression(expressionString);
        var printer = new Printer();

        int paddingLength = Helper.CalculatePaddingLength(expressionString);
        printer.SetHorizontalLineWidth(paddingLength.ToString());
        
        printer.AddToExpressionSequences(tokens.ToList());
        
        var parenthesisSets = Validation.HasParenthesesSets(tokens);
        Console.WriteLine(parenthesisSets);
        
        // if parenthesis exists
        bool hasParentheses;
        do
        {
            hasParentheses = false;
            var (startIndex, endIndex) = Helper.FindDeepestParenthesesIndices(tokens);
        
            if (startIndex != -1 && endIndex != -1)
            {
                hasParentheses = true;
                tokens = ProcessParentheses(startIndex, endIndex, tokens, printer);
            }
        } 
        while (hasParentheses);

        // if no more parenthesis, processing rest of expression
        if (tokens.Length > 1)
        {
            CalcFlat(tokens, printer);
        }

        printer.CalculatingSequence();
    }

    private static string[] ProcessParentheses(int startIndex, int endIndex, string[] tokens, Printer printer)
    {
        // get extension part in the parenthesis
        string[] innerTokens = tokens
            .Skip(startIndex + 1)
            .Take(endIndex - startIndex - 1)
            .ToArray();
        
        //printer.AddToExpressionSequences(tokens.ToList());
        
        // processing extension part
        while (innerTokens.Length > 1)
        {
            int operatorIndex = Operator.Index(innerTokens);
           // if (Helper.IsInvalidOperatorIndex(operatorIndex, innerTokens.Length))
            //    break;

            printer.AddToOperationSteps((startIndex + 1 + operatorIndex).ToString());
        
            string left = innerTokens[operatorIndex - 1];
            string op = innerTokens[operatorIndex];
            string right = innerTokens[operatorIndex + 1];

            string result = Expression.Calc(left, op, right);

            innerTokens = Helper.ReplaceWithResult(innerTokens, operatorIndex, result).ToArray();
        
            // renew head tokens
            var newTokens = tokens.Take(startIndex + 1)
                .Concat(innerTokens)
                .Concat(tokens.Skip(endIndex))
                .ToArray();
        
            printer.AddToExpressionSequences(newTokens.ToList());
            tokens = newTokens;
            endIndex = startIndex + innerTokens.Length + 1;
        }

        // replace parenthesis with a result
        if (innerTokens.Length == 1)
        {
            var finalTokens = tokens.Take(startIndex)
                .Concat(new[] { innerTokens[0] })
                .Concat(tokens.Skip(endIndex + 1))
                .ToArray();
        
            printer.AddToExpressionSequences(finalTokens.ToList());
            return finalTokens;
        }
    
        return tokens;
    }
    
    private static void CalcFlat(string[] tokens, Printer printer)
    {
        while (tokens.Length > 1)
        {
            
            // search for next operator index in array
            int operatorIndex = Operator.Index(tokens);
            //Console.WriteLine(operatorIndex);
            
            if (Helper.IsInvalidOperatorIndex(operatorIndex, tokens.Length))
                break;

            //
            //
            //
            printer.AddToOperationSteps(operatorIndex.ToString());
            
            string left = tokens[operatorIndex - 1];
            string op = tokens[operatorIndex];
            string right = tokens[operatorIndex + 1];

            string result = Expression.Calc(left, op, right);

            List<string> updatedTokens = Helper.ReplaceWithResult(tokens, operatorIndex, result);
            tokens = updatedTokens.ToArray();
            printer.AddToExpressionSequences(updatedTokens);
        }
    }
}