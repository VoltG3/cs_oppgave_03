namespace  cs_oppgave_03;

// Return: Priority Operator Index
//   Multiplication (*)
//   Division (/)
//   Addition (+) and
//   Subtraction (-) 

public class Operator
{
    public static int Index(string[] arr)
    {
        string charMul = "*"; bool boolMul = false;
        string charDiv = "/"; bool boolDiv = false;
        string charAdd = "+"; 
        string charSub = "-"; 
        
        int targetPriorityOperatorIndex = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == charSub && targetPriorityOperatorIndex == 0)
            {
                targetPriorityOperatorIndex = i;
            }
            
            else if (arr[i] == charAdd && boolMul == false && boolDiv == false)
            {
                boolMul = true;
                targetPriorityOperatorIndex = i;
            }
            
            else if (arr[i] == charDiv && boolDiv == false && boolDiv == false)
            {
                boolDiv = true;
                targetPriorityOperatorIndex = i;
            }
        }
        
        return targetPriorityOperatorIndex;
    }
}