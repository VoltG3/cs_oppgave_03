namespace  cs_oppgave_03;

public class Operator
{
    public static int Index(string[] arr)
    {
        // first priority: '*' and '/'
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == "*" || arr[i] == "/")
            {
                return i;
            }
        }

        // second priority: '+' un '-'
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == "+" || arr[i] == "-")
            {
                return i;
            }
        }

        return -1;
    }
}