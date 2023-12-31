namespace Domain.Contracts.Kpi;

public class KpiTargetResponse
{
    public Guid id { get; set; }
    
    public Entities.Kpi.Kpi? KpiId { get; set; }
    
    public float? TargetValue { get; set; }
    
    public DateTime? StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    public string? OutcomeNotification { get; set; }
}