namespace cs_oppgave_03;

public class Printer
{
    public Header Header { get; } = new Header();
    public Content Content { get; } = new Content();
    public Footer Footer { get; } = new Footer();

   
    public List<List<string>> ExpressionSequences { get; } = new();
    public List<string> OperationSteps { get; } = new();
    public string TotalLength { get; private set; } = "0";

    
    public void AddList(List<string> list) => ExpressionSequences.Add(list);
    public void AddStep(string step) => OperationSteps.Add(step);
    public void SetTotalLength(string value) => TotalLength = value;

   
    public void CalculatingSequence()
    {
        if (ExpressionSequences.Count == 0) return;

        Header.Print(TotalLength, ExpressionSequences[0]);
        Content.Print(ExpressionSequences, OperationSteps);
        Footer.Print(TotalLength, string.Join(" ", ExpressionSequences[^1]));
    }
}