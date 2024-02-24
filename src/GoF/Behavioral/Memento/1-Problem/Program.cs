// The Problem:

// Picture yourself making a text editor app.
// Apart from basic text editing, your editor
// can also do things like formatting text and
// adding pictures within the text.
// 
// At one point, you thought it would be good
// to allow users to undo any changes they make
// to the text. This feature has become so common
// that people now assume every app should have it.
// 
// Now, here's the challenge:
// Save the internal state of an object outside,
// so you can restore the object to that state later.

var editor = new Editor();
editor.SetContent("a");
editor.SetContent("b");
editor.SetContent("c");
// editor.Undo();

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
}