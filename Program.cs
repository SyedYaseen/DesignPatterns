using System.Threading.Channels;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Device;
using DesignPatterns.BuilderPattern;
using DesignPatterns.BuilderPattern.ExportPowerPoint;
using DesignPatterns.MementoUndoPattern;
using DesignPatterns.PrototypePattern.Demo;
using DesignPatterns.StatePattern;
using DesignPatterns.StatePattern.Demo;
using DesignPatterns.StatePattern.Demo.Tools;
using DesignPatterns.StatePattern.Exercise;
using DesignPatterns.StatePattern.Exercise.TravelModes;
using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.Demo;
using DesignPatterns.StrategyPattern.Demo.CompressionAlgo;
using DesignPatterns.StrategyPattern.Demo.Filters;using DesignPatterns.TemplateMethodPattern.DemoPractice;
using DesignPatterns.TemplateMethodPattern.DemoPractice.Tasks;
using Task = DesignPatterns.TemplateMethodPattern.DemoPractice.Task;

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

// var _builder = new PdfBuilder();
// var presentation = new Presentation();
// presentation.AddSlide("This");
// presentation.AddSlide("That");
// presentation.AddSlide("What");
// presentation.Export(_builder);
//
// var pdf = _builder.GetPdf();

//Prototype Pattern
// IComponent circle1 = new Circle(5);
// var circle2 = circle1.Duplicate();


//Strategy Pattern
// ImageStorage imgStore = new ImageStorage();
// imgStore.StoreImage(new Image("Cat photo"), new JPGCompression(), new VividFilter();

//Template Method

AuditTrail trail = new AuditTrail();
Task genReport = new GenerateReport(trail);
genReport.Execute();
Task txn1 = new MakeTransaction(trail);
txn1.Execute();

