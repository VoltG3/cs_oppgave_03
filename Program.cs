namespace cs_oppgave_03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("cs_oppgave_03 -> onloaded");

        // ToDo :
        //      1. Recursively process the array until array.Length == 1
        //      2. Find the 'first operator' with the 'highest priority'
        //      3. Store the 'position' of this 'highest priority operator' 
        //      4. Expression: P[i-1] P[i] P[i+1] = P[Number Calc Number]
        //      5. Remove elements at P[i] and P[i+1], shrink the array by 2
        //      5. Replace P[i-1] with expression result
        //      6. Repeat from step 1 with the updated array
        
        // Operator Priority:
        // 1. Multiplication (*)
        // 2. Division (/)
        // 3. Addition (+) and Subtraction (-) – equal precedence, evaluate left to right
        
        string preDefinedUserInput = "12 + 12 - 4 * 3 / 7";
        //Console.WriteLine("preDefinedUserInput");
       // Console.WriteLine(preDefinedUserInput);
       // Console.WriteLine($"length: { preDefinedUserInput.Length}");
        
        // init Array and Array length
        string[] rawArray = preDefinedUserInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < rawArray.Length; i++)
        {
           // Console.WriteLine($"{i}: {rawArray[i]}");

            if (rawArray[i] == "+" && i - 1 >= 0 && i + 1 < rawArray.Length)
            {
                    string r = rawArray[i - 1] + rawArray[i] + rawArray[i + 1];
                    Console.WriteLine($" expession { r }");
                
                Calculate calc = new Calculate();
                string result = calc.Expression(rawArray[i - 1], rawArray[i], rawArray[i + 1]);
                Console.WriteLine($" result { result }");
            }
         
        }
        
        // Get PriorityOperatorIndex
        /*
        string FirstIndex = Operator.Index(rawArray).ToString();
        Console.WriteLine($"PriorityOperatorIndex: { FirstIndex }");
        */
        
        /*
        // Debug Calculator
        Calculator cal = new Calculator();
        Console.WriteLine(cal.Multiply(3, 4));
        Console.WriteLine(cal.Multiply(3.9, 4.9));
        Console.WriteLine(cal.Divide(3, 4));
        Console.WriteLine(cal.Divide(3.9, 4.9));
        Console.WriteLine(cal.Add(3, 2));
        Console.WriteLine(cal.Add(3.6, 2.5));
        Console.WriteLine(cal.Subtract(3, 2));
        Console.WriteLine(cal.Subtract(3.8, 2.9));
        */
    }
}