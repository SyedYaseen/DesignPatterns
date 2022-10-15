using DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes;
using DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes.Operations;

namespace DesignPatterns.VisitorPattern.DemoPractice;

public class HtmlDocument
{
    private List<IHtmlNode> HtmlNodes = new List<IHtmlNode>();

    public void AddNode(IHtmlNode htmlNode)
    {
        HtmlNodes.Add(htmlNode);
    }

    public void Execute(IOperations operation)
    {
        foreach (var htmlNode in HtmlNodes)
        {
            htmlNode.Execute(operation);
        }
    }

}