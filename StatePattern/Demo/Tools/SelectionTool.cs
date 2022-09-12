namespace DesignPatterns.StatePattern.Tools;

public class SelectionTool: ITool
{
    public void mouseUp()
    {
        Console.WriteLine("Selection tool: Show icon");
    }

    public void mouseDown()
    {
        Console.WriteLine("Selection tool: Create a dotted line box");
    }
}