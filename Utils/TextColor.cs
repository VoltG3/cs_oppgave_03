namespace cs_oppgave_03;

public class TextColor
{
    public static class Color
    {
        public const string RS = "\u001B[0m";    // Rest
        public const string GR = "\u001B[32m";   // Green
        public const string YL = "\u001B[33m";   // Yellow
        public const string BL = "\u001B[34m";   // Blue
        public const string PR = "\u001B[35m";   // Purple
        public const string CY = "\u001B[36m";   // Cyan
        public const string RD = "\u001B[31m";   // Red
        
        public const string WH_B = "\u001B[97m";   // Bright White
        public const string BK_B = "\u001B[90m";   // Bright Black (Gray)
        public const string RD_B = "\u001B[91m";   // Bright Red
        public const string GR_B = "\u001B[92m";   // Bright Green
        public const string YL_B = "\u001B[93m";   // Bright Yellow
        public const string BL_B = "\u001B[94m";   // Bright Blue
        public const string PR_B = "\u001B[95m";   // Bright Purple (Bright Magenta)
        public const string CY_B = "\u001B[96m";   // Bright Cyan
    }
}