public class Editor
{
    private string content;
    private readonly EditorHistory editorHistory;

    public Editor()
    {
        this.editorHistory = new EditorHistory();
    }

    public string GetContent()
    {
        return content;
    }

    public void SetContent(string content)
    {
        editorHistory.Push(CreateState());
        this.content = content;
    }

    public EditorState CreateState()
    {
        return new EditorState(content);
    }

    public void Restore()
    {
        var previousState = editorHistory.Pop();

        if (previousState is null)
            content = String.Empty;
        else
            content = previousState.GetContent();
    }
}