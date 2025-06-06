namespace cs_oppgave_03;

public class Calculator
{
    public static void Calc(string expressionString)
    {
        string[] tokens = Helper.PrepareExpression(expressionString);
        var printer = new Printer();

        int paddingLength = Helper.CalculatePaddingLength(expressionString);
        printer.SetTotalLength(paddingLength.ToString());
        
        printer.AddList(tokens.ToList());

        while (tokens.Length > 1)
        {
            int operatorIndex = Operator.Index(tokens);
            if (Helper.IsInvalidOperatorIndex(operatorIndex, tokens.Length))
                break;

            printer.AddStep(operatorIndex.ToString());

            string left = tokens[operatorIndex - 1];
            string op = tokens[operatorIndex];
            string right = tokens[operatorIndex + 1];

            string result = Expression.Calc(left, op, right);

            List<string> updatedTokens = Helper.ReplaceWithResult(tokens, operatorIndex, result);
            tokens = updatedTokens.ToArray();
            printer.AddList(updatedTokens);
        }

        printer.CalculatingSequence();
    }
}