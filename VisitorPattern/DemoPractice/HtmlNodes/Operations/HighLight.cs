namespace DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes.Operations;

public class HighLight : IOperations
{
    public void Apply(AnchorNode anchorNode)
    {
        Console.WriteLine($"Highlighted {anchorNode.GetType().Name}");
    }

    public void Apply(ParagraphNode paragraphNode)
    {
        Console.WriteLine($"Highlighted {paragraphNode.GetType().Name}");
    }

    public void Apply(SpanNode spanNode)
    {
        Console.WriteLine($"Highlighted {spanNode.GetType().Name}");
    }
}