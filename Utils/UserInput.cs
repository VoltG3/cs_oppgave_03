namespace cs_oppgave_03;

public class UserInput
{
    public static bool IsInvalid(string userString)
    {
        string[] token = userString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var invalidIndices = new List<int>();
        bool isTokenCorrupted = false;
        
        for (int i = 0; i < token.Length; i++)
        {
            string tokenItem = token[i];
            
            bool isInt = Validation.IsInteger(tokenItem);
            bool isDouble = Validation.IsDouble(tokenItem);
            bool isOperator = Validation.IsOperator(tokenItem);
            
            if (!(isInt || isDouble || isOperator))
            {
                invalidIndices.Add(i);
                isTokenCorrupted = true;
            }
        }

        if (isTokenCorrupted)
        {
            var invalid = new HashSet<int>(invalidIndices);
            
            TextFormat.Space(1);
            Console.WriteLine($"{ TextFormat.Border(3)}{ TextColor.Color.RD_B }Invalid input{ TextColor.Color.RS }");
            
            Console.Write($"{ TextFormat.Border(3) }");
            for (int i = 0; i < token.Length; i++)
            {
               var color = invalid.Contains(i) ? TextColor.Color.RD_B : TextColor.Color.BL_B;
               Console.Write($"{ color }{ token[i] }{ TextColor.Color.RS } ");
            }
            TextFormat.Space(1);
            
            return true;
        }
        
        return false;
    }
}