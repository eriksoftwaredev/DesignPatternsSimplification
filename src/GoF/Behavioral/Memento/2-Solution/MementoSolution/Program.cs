// Solution:

// We need to save an object's internal state externally,
// allowing us to revert to that state when necessary.

// Look at the 'png' file MementoUMLDiagram.png in the root

// In this example, the Editor class (Originator)
// manages its state with the help of
// the inner EditorState class (Memento).
// The EditorHistory class (Caretaker)
// keeps track of saved states,
// allowing for easy undo functionality.

// Understanding and implementing the Memento pattern
// can greatly enhance the flexibility of your applications,
// especially when it comes to managing and reverting object states.

var editor = new Editor();
var editorHistory = new EditorHistory();

editor.SetContent("a");
editorHistory.Push(editor.CreateState());

editor.SetContent("b");
editorHistory.Push(editor.CreateState());

editor.SetContent("c");
editor.Restore(editorHistory.Pop());

Console.WriteLine(editor.GetContent()); // output: b

editor.Restore(editorHistory.Pop());
Console.WriteLine(editor.GetContent()); // output: a