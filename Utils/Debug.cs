namespace  cs_oppgave_03;

public class Debug
{
    public static void DebuggArray(string[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{ item }{ (char)160 }");
        }
        
        Console.WriteLine("");
    }
}