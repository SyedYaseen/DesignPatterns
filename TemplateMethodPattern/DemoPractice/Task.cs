using DesignPatterns.BuilderPattern;

namespace DesignPatterns.TemplateMethodPattern.DemoPractice;

public abstract class Task
{
    private AuditTrail _auditTrail;
    
    public Task()
    {
        _auditTrail = new AuditTrail();
    }

    public Task(AuditTrail auditTrail)
    {
        _auditTrail = auditTrail;
    }
    
    public void Execute()
    {
        string taskPerformed = this.GetType().Name;
        _auditTrail.Record(taskPerformed);
        TaskImplementation();
    }

    protected abstract void TaskImplementation();
}