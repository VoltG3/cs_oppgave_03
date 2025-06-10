namespace cs_oppgave_03;

public class Printer
{
    private class PrinterData
    {
        public List<List<string>> ExpressionSequences { get; } = new();
        public List<string> OperationSteps { get; } = new();
        public string TotalLength { get; set; } = "0";
    }

    private readonly PrinterData _data = new();
    private readonly Header _header = new();
    private readonly Content _content = new();
    private readonly Footer _footer = new();

    public void AddToExpressionSequences(List<string> list) => _data.ExpressionSequences.Add(list);
    public void AddToOperationSteps(string step) => _data.OperationSteps.Add(step);
    public void SetHorizontalLineWidth(string value) => _data.TotalLength = value;

    public void CalculatingSequence()
    {
        if (_data.ExpressionSequences.Count == 0) return;

        _header.Print(_data.TotalLength, _data.ExpressionSequences[0]);
        _content.Print(_data.ExpressionSequences, _data.OperationSteps);
        _footer.Print(_data.TotalLength, string.Join(" ", _data.ExpressionSequences[^1]));
    }
}