namespace DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes.Operations;

public class PlainText : IOperations
{
    public void Apply(AnchorNode anchorNode)
    {
        Console.WriteLine($"Converted Anchor to plain text");
    }

    public void Apply(ParagraphNode paragraphNode)
    {
        Console.WriteLine($"Converted Paragraph to plain text");
    }

    public void Apply(SpanNode spanNode)
    {
        Console.WriteLine($"Converted Span to plain text");
    }
}