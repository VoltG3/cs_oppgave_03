namespace cs_oppgave_03;

public class Calculator
{
    public static void Calc(string expressionString)
    {
        string[] tokens = Helper.PrepareExpression(expressionString);
        var printer = new Printer();

        int paddingLength = Helper.CalculatePaddingLength(expressionString);
        printer.SetHorizontalLineWidth(paddingLength.ToString());
        
        //printer.AddToExpressionSequences(Helper.PrepareExpressionForPrinter(tokens.ToList()));
        
        Debug.DebuggArray(tokens);
        
        //printer.AddToExpressionSequences(tokens.ToList());
        
        var tpm = tokens;
        var tmpR = Helper.PrepareExpressionForPrinter(tpm);

        foreach (var item in tmpR)
        {
            Console.Write($"{item}{(char)160}");
        }
        
        //Console.WriteLine(tmpR);
        
        //Debug.DebuggArray(tokens);(6 + 5) - (5 - 5)
        //printer.AddToExpressionSequences(Helper.PrepareExpressionForPrinter(tokens).ToList());
        printer.AddToExpressionSequences(tokens.ToList());
        
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
                
                // for printer count of parenthesis sets
                var parenthesisSets = Validation.HasParenthesesSets(tokens);
                Console.WriteLine(parenthesisSets);
                printer.SetExpressionHasParenthesis(parenthesisSets.ToString());
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

    private static string[] ProcessParentheses(int start, int end, string[] tokens, Printer printer)
    {
        // content between parenthesis
        var innerTokens = tokens.Skip(start + 1)
            .Take(end - start - 1)
            .ToArray();

        Debug.DebuggArray(innerTokens);

        // if inside only one number, then remove parenthesis
        if (innerTokens.Length == 1)
        {
            var noBrackets = tokens.Take(start)
                .Concat(innerTokens)        // alone number
                .Concat(tokens.Skip(end + 1))
                .ToArray();

            
            
            
            
            
            
            printer.AddToExpressionSequences(noBrackets.ToList());
            //printer.AddToExpressionSequences(Helper.PrepareExpressionForPrinter(tokens).ToList());
            return noBrackets;
        }

        // else execute only one operation
        int opIndex = Operator.Index(innerTokens);

        if (opIndex <= 0 || opIndex + 1 >= innerTokens.Length)
            return tokens;

        printer.AddToOperationSteps((start + 1 + opIndex).ToString());

        string left  = innerTokens[opIndex - 1];
        string op    = innerTokens[opIndex];
        string right = innerTokens[opIndex + 1];

        string result = Expression.Calc(left, op, right);

        innerTokens = Helper.ReplaceWithResult(innerTokens, opIndex, result).ToArray();

        // after calculating check: (delete or not) parenthesis
        string[] updatedTokens = (innerTokens.Length == 1)
            ?  // one token, then remove parenthesis
            tokens.Take(start)
                .Concat(innerTokens)
                .Concat(tokens.Skip(end + 1))
                .ToArray()
            :  // more than one token, then no remove parenthesis
            tokens.Take(start + 1)
                .Concat(innerTokens)
                .Concat(tokens.Skip(end))
                .ToArray();

        printer.AddToExpressionSequences(updatedTokens.ToList());
        //printer.AddToExpressionSequences(Helper.PrepareExpressionForPrinter(tokens).ToList());
        return updatedTokens;
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
            //printer.AddToExpressionSequences(Helper.PrepareExpressionForPrinter(tokens).ToList());
        }
    }
}