namespace DesignPatterns.StatePattern.Demo;

public class Canvas
{
    private ITool currentTool;

    public void mouseUp()
    {
        currentTool.mouseUp();
    }

    public void mouseDown()
    {
        currentTool.mouseDown();
    }

    public ITool getCurrentTool()
    {
        return currentTool;
    }

    public void setCurrentTool(ITool tool)
    {
        currentTool = tool;
    }

}