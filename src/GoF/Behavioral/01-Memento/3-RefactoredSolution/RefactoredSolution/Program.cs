// I've simplified and enhanced the user experience in the following ways:

// - Automatically initializes EditorHistory and CreateState within the Editor class.
// - Streamlined the process by automatically handling Push and Pop calls within the Editor class.

var editor = new Editor();

editor.SetContent("a");
editor.SetContent("b");
editor.SetContent("c");
editor.Restore();

Console.WriteLine(editor.GetContent()); // output: b

editor.Restore();
Console.WriteLine(editor.GetContent()); // output: a