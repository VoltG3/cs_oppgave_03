namespace cs_oppgave_03;

public static class Formatting
{
    public static string IsUnformattedDouble(string item)
    {
        bool isDouble = double.TryParse(item, out var number);
        
        if(!isDouble) return item;
        
        if (number % 1 == 0) return ((int)number).ToString();
        return Math.Round(number, 2).ToString("0.##");
    }

    public static string[] IsUnformattedDoubleInArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (Validation.IsDouble(arr[i]))
            {
                arr[i] = IsUnformattedDouble(arr[i]);
            }
        }

        return arr;
    }
}