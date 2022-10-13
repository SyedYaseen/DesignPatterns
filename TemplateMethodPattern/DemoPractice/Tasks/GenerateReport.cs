namespace DesignPatterns.TemplateMethodPattern.DemoPractice.Tasks;

public class GenerateReport : Task
{
    public GenerateReport(AuditTrail trail) : base(trail)
    {
        
    }
    
    protected override void TaskImplementation()
    {
        Console.WriteLine("Generate report");
    }
}