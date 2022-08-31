namespace DesignPatterns.MementoUndoPattern;

public class History
{
    private Stack<EditorState>? states = new Stack<EditorState>();
    
    public void PushState(EditorState state)
    {
        states?.Push(state);
    }
    
    public EditorState PopState()
    {
        return states?.Pop();
    }
}