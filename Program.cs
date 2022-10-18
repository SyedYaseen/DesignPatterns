using System.Threading.Channels;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Device;
using DesignPatterns.AdapterPattern.DemoPractice;
using DesignPatterns.AdapterPattern.DemoPractice.Filters.ThirdPartyFilters;
using DesignPatterns.BuilderPattern;
using DesignPatterns.BuilderPattern.ExportPowerPoint;
using DesignPatterns.ChainOfResponsibilityPattern.DemoPractice;
using DesignPatterns.ChainOfResponsibilityPattern.DemoPractice.Handlers;
using DesignPatterns.CompositePattern.DemoPractice;
using DesignPatterns.MementoUndoPattern;
using DesignPatterns.ObserverPattern.DemoPractice.Observers;
using DesignPatterns.ObserverPattern.DemoPractice.Subjects;
using DesignPatterns.PrototypePattern.Demo;
using DesignPatterns.SingletonPattern.DemoPractice;
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
using DesignPatterns.VisitorPattern.DemoPractice;
using DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes;
using DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes.Operations;
using File = DesignPatterns.CompositePattern.DemoPractice.File;
using Image = DesignPatterns.AdapterPattern.DemoPractice.Image;
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
// AuditTrail trail = new AuditTrail();
// Task genReport = new GenerateReport(trail);
// genReport.Execute();
// Task txn1 = new MakeTransaction(trail);
// txn1.Execute();

//Observer pattern
// DataSource dataSource = new DataSource();
//Data source is passed to create coupling between
//datasource class and the observers to enable PULL style communication
// IObserver datatable = new DataTable(dataSource);
// IObserver flowchart = new FlowChart(dataSource);
// dataSource.AddObserver(datatable);
// dataSource.AddObserver(flowchart);
// dataSource.SetData("yaseen");

//ChainOfResponsibility
//Creating the chain of tasks to be performed in reverese order
// Actual required flow: Auth --> Logger --> Compressor 
// var compressor = new Compression(null);
// var logger = new Logger(compressor);
// var auth = new Authentication(logger);
//
// //Passing first value on to the web server, so it can start working
// var webServer = new WebServer(auth);
// HttpRequest httpRequest = new HttpRequest("Admin", 1234);
// webServer.Handle(httpRequest);


//VisitorPattern
// HtmlDocument htmlDocument = new HtmlDocument();
// htmlDocument.AddNode(new AnchorNode());
// htmlDocument.AddNode(new ParagraphNode());
//
// htmlDocument.Execute(new HighLight());


//SingletonPattern
// var configManager = ConfigManager.GetInstance();
// configManager.SetConfig(1, "Yaseen");
//
// var configManager2 = ConfigManager.GetInstance();
//
// Console.WriteLine(configManager2.GetConfig(2));

//Composite Pattern
// File file1 = new File();
// File file2 = new File();
// Group group1 = new Group();
// group1.AddItems(file1);
// group1.AddItems(file2);
// // group1.Render();
//
// Group group2 = new Group();
// group2.AddItems(group1);
// group2.Render();


//Adapter pattern
Image img = new Image();
ImagePreview imagePreview = new ImagePreview(img);
imagePreview.ApplyFilter(new CaramelAdapter(new Caramel()));