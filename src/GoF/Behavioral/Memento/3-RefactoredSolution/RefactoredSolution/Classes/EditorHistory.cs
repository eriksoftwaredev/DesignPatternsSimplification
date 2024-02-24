using System.ComponentModel.DataAnnotations;

public class EditorHistory
{
    private Stack<EditorState> states = new();

    public void Push(EditorState state) => states.Push(state);

    public EditorState Pop()
    {
        EditorState state;
        states.TryPop(out state);
        
        return state;
    }
}