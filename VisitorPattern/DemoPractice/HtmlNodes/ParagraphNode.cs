using DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes.Operations;

namespace DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes;

public class ParagraphNode : IHtmlNode
{
    public void Execute(IOperations operation)
    {
        operation.Apply(this);
    }
}