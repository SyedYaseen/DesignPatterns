namespace DesignPatterns.MementoUndoPattern;

public class Editor
{
    private string? _content;

    public string GetContent()
    {
        return _content;
    }

    public void SetContent(string content)
    {
        _content = content;
    }
    
    public EditorState CreateState()
    {
        return new EditorState(_content);
    }

    public void RestoreState(EditorState state)
    {
        _content = state.GetContent();
    }
}
