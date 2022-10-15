using System.Security.Cryptography;

namespace DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes.Operations;

public interface IOperations
{
    void Apply(AnchorNode anchorNode);
    void Apply(ParagraphNode paragraphNode);
    void Apply(SpanNode spanNode);
}