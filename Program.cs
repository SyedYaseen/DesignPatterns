using System.Threading.Channels;
using DesignPatterns.MementoUndoPattern;

//Memento
var editor = new Editor();
var history = new History();

editor.SetContent("This");

history.PushState(editor.CreateState());
editor.SetContent("Is");

history.PushState(editor.CreateState());
Console.WriteLine("First time:" + editor.GetContent());

editor.SetContent("Sparta!");
editor.RestoreState(history.PopState());

Console.WriteLine("Second time:" + editor.GetContent());





