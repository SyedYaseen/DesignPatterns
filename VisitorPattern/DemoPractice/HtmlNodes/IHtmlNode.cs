using DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes.Operations;

namespace DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes;

public interface IHtmlNode
{
   void Execute(IOperations operation);
}