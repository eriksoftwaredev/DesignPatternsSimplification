public class Editor
{
    private string content;

    public string GetContent()
    {
        return content;
    }

    public void SetContent(string content)
    {
        this.content = content;
    }

    public EditorState CreateState()
    {
        return new EditorState(content);
    }

    public void Restore(EditorState state)
    {
        if (state is null)
            content = String.Empty;
        else
            content = state.GetContent();
    }
}