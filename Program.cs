using System.Threading.Channels;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Device;
using DesignPatterns.MementoUndoPattern;
using DesignPatterns.StatePattern;
using DesignPatterns.StatePattern.Demo;
using DesignPatterns.StatePattern.Demo.Tools;
using DesignPatterns.StatePattern.Exercise;
using DesignPatterns.StatePattern.Exercise.TravelModes;

//Abstract Factory Demo
new NavBar(new AppleUi());
new DropDown(new AndroidUi());


//State Pattern - demo
// var canvas = new Canvas();
// canvas.setCurrentTool(new SelectionTool());
// canvas.mouseUp();
// canvas.mouseDown();

//State Pattern - Exercise
// var travelCalc = new TravelCalc(new Driving());
// travelCalc.GetTravelMode();
// travelCalc.GetETA();


//Memento Pattern
// var editor = new Editor();
// var history = new History();
//
// editor.SetContent("This");
//
// history.PushState(editor.CreateState());
// editor.SetContent("Is");
//
// history.PushState(editor.CreateState());
// Console.WriteLine("First time:" + editor.GetContent());
//
// editor.SetContent("Sparta!");
// editor.RestoreState(history.PopState());
//
// Console.WriteLine("Second time:" + editor.GetContent());





