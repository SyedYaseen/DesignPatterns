namespace DesignPatterns.TemplateMethodPattern.DemoPractice.Tasks;

public class MakeTransaction : Task
{
    public MakeTransaction(AuditTrail trail) : base(trail)
    {
        
    }

    protected override void TaskImplementation()
    {
        Console.WriteLine("Made transaction");
    }
}