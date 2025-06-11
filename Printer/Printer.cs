namespace cs_oppgave_03;

public class Printer
{
    private class PrinterData
    {
        public List<List<string>> ExpressionSequences { get; } = new();
        public List<string> OperationSteps { get; } = new();
        public List<string> ExpressionHasParenthesis { get; } = new();
    }

    private readonly PrinterData _data = new();
    private readonly SectionHeader _sectionHeader = new();
    private readonly SectionContent _sectionContent = new();
    private readonly SectionFooter _sectionFooter = new();

    public void AddToExpressionSequences(List<string> list) => _data.ExpressionSequences.Add(list);
    public void AddToOperationSteps(string step) => _data.OperationSteps.Add(step);
    public void SetExpressionHasParenthesis(string brackets) => _data.ExpressionHasParenthesis.Add(brackets);

    public void CalculatingSequence()
    {
        if (_data.ExpressionSequences.Count == 0) return;

        _sectionHeader.Print(_data.ExpressionSequences[0]);
        _sectionContent.Print(_data.ExpressionSequences, _data.OperationSteps, _data.ExpressionHasParenthesis);
        _sectionFooter.Print(string.Join(" ", _data.ExpressionSequences[^1]));
    }
}