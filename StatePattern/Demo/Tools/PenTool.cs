namespace DesignPatterns.StatePattern.Tools;

public class PenTool: ITool
{
    public void mouseUp()
    {
        Console.WriteLine("Pen tool: Show icon");
    }

    public void mouseDown()
    {
        Console.WriteLine("Pen tool: Create a line");
    }
}