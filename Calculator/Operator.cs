namespace  cs_oppgave_03;

public class Operator
{
    public static int Index(string[] arr)
    {
        // Priority sequence: * / + -
        string[] priority = new[] { "*", "/", "+", "-" };

        foreach (string op in priority)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == op)
                {
                    return i;
                }
            }
        }
        
        return -1;
    }
}