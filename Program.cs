using System.Threading.Channels;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Device;
using DesignPatterns.BuilderPattern;
using DesignPatterns.BuilderPattern.ExportPowerPoint;
using DesignPatterns.MementoUndoPattern;
using DesignPatterns.StatePattern;
using DesignPatterns.StatePattern.Demo;
using DesignPatterns.StatePattern.Demo.Tools;
using DesignPatterns.StatePattern.Exercise;
using DesignPatterns.StatePattern.Exercise.TravelModes;

//Abstract Factory Demo
// new NavBar(new AppleUi());
// new DropDown(new AndroidUi());


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


// Builder pattern
// var director = new Director();
// var builder = new ConcreteBuilderA();
// director.Builder = builder;
// director.CreateFullProduct();
// Console.WriteLine(builder.GetProduct().ListProducts());

var _builder = new PdfBuilder();
var presentation = new Presentation();
presentation.AddSlide("This");
presentation.AddSlide("That");
presentation.AddSlide("What");
presentation.Export(_builder);

var pdf = _builder.GetPdf();




