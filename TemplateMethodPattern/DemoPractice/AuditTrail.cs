namespace DesignPatterns.TemplateMethodPattern.DemoPractice;

public class AuditTrail
{
   private List<string> auditTrailList;

   public AuditTrail()
   {
      auditTrailList = new List<string>();
   }

   public void Record(string taskName)
   {
      auditTrailList.Add(taskName);
      Console.WriteLine("Audited action");
   }
}